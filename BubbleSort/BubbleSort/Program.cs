// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

int[] arr = { 78, 55, 45, 98, 13 };

var temp = 0;

for (int j = 0; j <= arr.Length - 2; j++)
{
    for (int i = 0; i <= arr.Length - 2; i++)
        {
        if ((i + 1) < arr.Length && arr[i] > arr[i + 1])
        {            
            temp = arr[i + 1];
            arr[i + 1] = arr[i];
            arr[i] = temp;
        } 
    }
}

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}