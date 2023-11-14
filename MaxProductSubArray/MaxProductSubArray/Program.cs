// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] array = { 2, 3, -2, 4 };
List<int> products = new();

for (int i = 0; i < array.Length; i++)
{
    if (i < array.Length - 1)
    {
        products.Add(array[i] * array[i + 1]);
    }
    if (i - 1 >= 0)
    {
        products.Add(array[i - 1] * array[i]);
    }
}

Console.WriteLine(products.Max());