// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] inputArray = { -23, 4, -3, 8, -12 };

var product = 0;
var maxProduct = 0;

for (int i = 0; i < inputArray.Length; i++)
{
    if (i + 1 < inputArray.Length)
    {
        product = inputArray[i] * inputArray[i + 1];
        Console.WriteLine(product);
    }

    if (maxProduct == 0 || product > maxProduct)
    {
        maxProduct = product;
    }
}

Console.WriteLine(maxProduct);
