using System.Text;

public class Stories
{
    public static int NumberOfArrangements(int numberOfStories)
    {
        var arrangements = new List<string>();

        StringBuilder arrgement;        

        var apartments = new Dictionary<int, string>();
        apartments.Add(1, "small");
        apartments.Add(2, "large");       

        for (int i = 1; i <= 2; i++)
        {
            arrgement = new StringBuilder();

            if (numberOfStories % i == 0)
            {
                for (int j = 1; j <= numberOfStories; j++)
                {
                    arrgement.Append($"{apartments[i]},");
                }
            }

            arrangements.Add(arrgement.ToString());
        }

        int remainingSpace = numberOfStories;

        while (remainingSpace > 0)
        {
            var largeCount = remainingSpace / 2;
            var smallCount = remainingSpace % 2;

            arrgement = new StringBuilder();

            for (int j = 1; j <= largeCount; j++)
            {
                arrgement.Append($"{apartments[2]},");
            }

            for (int j = 1; j <= smallCount; j++)
            {
                arrgement.Append($"{apartments[1]},");
            }

            arrangements.Add(arrgement.ToString());

            //arrgement = new StringBuilder();

            //for (int j = 1; j <= smallCount; j++)
            //{
            //    arrgement.Append($"{apartments[1]},");
            //}

            //for (int j = 1; j <= largeCount; j++)
            //{
            //    arrgement.Append($"{apartments[2]},");
            //}          

            //arrangements.Add(arrgement.ToString());

            remainingSpace -= (largeCount + smallCount);
        }

        //for (int i = 1; i <= 2; i++)
        //{
        //    arrgement = new StringBuilder();

            //    remainingSpace = numberOfStories;

            //    while (remainingSpace > 0)
            //    {
            //        if (i > remainingSpace)
            //        {
            //            arrgement.Append($"{apartments[remainingSpace]},");
            //        }
            //        else
            //        {
            //            arrgement.Append($"{apartments[i]},");
            //        }

            //        remainingSpace -= i;
            //    }          

            //    arrangements.Add(arrgement.ToString());
            //}

            //for (int i = 2; i >= 1; i++)
            //{
            //    arrgement = new StringBuilder();

            //    remainingSpace = numberOfStories;

            //    while (remainingSpace <= 0)
            //    {
            //        if (i < remainingSpace)
            //        {
            //            arrgement.Append($"{apartments[remainingSpace]},");
            //        }
            //        else
            //        {
            //            arrgement.Append($"{apartments[i]},");
            //        }

            //        remainingSpace += i;
            //    }

            //    arrangements.Add(arrgement.ToString());
            //}


        foreach (var str in arrangements)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine();

        return arrangements.Count();
    }

    public static void Main(String[] args)
    {
        Console.WriteLine(NumberOfArrangements(4));
    }
}
