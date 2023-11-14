// See https://aka.ms/new-console-template for more information
var num1 = 1;
var num2 = 2;

Console.WriteLine($"num1={num1}");
Console.WriteLine($"num2={num2}");

Console.WriteLine($"Swapped....");

(num1, num2) = Swap(num1, num2);

Console.WriteLine($"num1={num1}");
Console.WriteLine($"num2={num2}");

(int, int) Swap(int num1, int num2) 
{
    var temp = num1;
    num1 = num2;
    num2 = temp;

    return (num1, num2);
}

