// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] ratings = { 1, 5, 2, 1};

int totalCandies = 0;
int previousCandy = 0;

for (int i = 0; i < ratings.Length; i++)
{
    if (i > 0 && ratings[i-1] < ratings[i])
    {
        ++previousCandy;    
    }
    else
    {
        previousCandy = 1;
        
    }
    totalCandies += previousCandy;
}

Console.WriteLine(totalCandies);

