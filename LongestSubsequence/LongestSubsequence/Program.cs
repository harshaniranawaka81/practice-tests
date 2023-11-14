// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> A = new () { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 };

List<int> Sorted = new();

var max = A[0];
Sorted.Add(max);
for (int i = 0; i < A.Count; i++)
{    
    if(A[i] > max)
    {
        max = A[i];
        Sorted.Add(max);
    }
}

for (int i = 0; i < A.Count; i++)
    Console.WriteLine(A[i]);

Console.WriteLine("Sorted");

for (int i = 0; i < Sorted.Count; i++)
    Console.WriteLine(Sorted[i]);