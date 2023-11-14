// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] input = { 1, 4, 10, 5, 3, 2 };

var inputList = input.ToList();

Queue<int> sortedArray = new();

while(inputList.Count > 0)
{
    var min = inputList.Min();
    sortedArray.Enqueue(min);
    inputList.RemoveAll(x=>x == min);    
}

foreach (var item in sortedArray)
{
    Console.WriteLine(item);
}