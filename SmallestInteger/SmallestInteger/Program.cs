// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] input = { 1, 3, 6, 4, 1, 2 };

int max = input.Max();
int min = input.Min();

var smallest = 0;

for (int i = max; i >= min; i--)
{
    var match = input.FirstOrDefault(x => x == i);
    if(match == 0)
    {
        smallest = i;
    }
}

Console.WriteLine(smallest);


