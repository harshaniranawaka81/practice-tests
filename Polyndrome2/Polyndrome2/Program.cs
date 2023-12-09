// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

string inputString = "abacaba";

char[] chars = inputString.ToCharArray();
Array.Reverse(chars);

Console.WriteLine();

if (string.Equals(inputString, new string(chars)))
{
    Console.WriteLine(true);
}
else
{
    Console.WriteLine(false);
}
