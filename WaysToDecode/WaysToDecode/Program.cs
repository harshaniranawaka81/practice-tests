// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string encoded = "12";

string charArray =  "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

List<(int, string)> combinations = new();

for (int i = 0; i < encoded.Length; i++)
{
    var position =  int.Parse(encoded.Substring(i, 1));
    var letters = charArray.Substring(position, 1);
    combinations.Add((position, letters));

    if (i + 2 <= encoded.Length)
    {
        position = int.Parse(encoded.Substring(i, 2));

        if (position < 26)
        {
            letters = charArray.Substring(position, 1);
            combinations.Add((position, letters));
        }
    }
}

foreach (var item in combinations)
{
    Console.WriteLine($"Position: {item.Item1}, Letters: {item.Item2}");
}

Console.WriteLine($"Combinations Count = {combinations.Count}");

