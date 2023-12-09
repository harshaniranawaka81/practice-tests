// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int value1 = 5, weight1 = 3, value2 = 7, weight2 = 4, maxW = 6;

int remWeight = maxW;

int totalVal1 = 0;

while (remWeight >= weight1 || remWeight >= weight2)
{
    if (remWeight - weight1 >= 0)
    {
        remWeight -= weight1;
        totalVal1 += value1;
    }

    if (remWeight - weight2 >= 0)
    {
        remWeight -= weight2;
        totalVal1 += value2;
    }
}

remWeight = maxW;

int totalVal2 = 0;

while (remWeight >= weight1 || remWeight >= weight2)
{
    if (remWeight - weight2 >= 0)
    {
        remWeight -= weight2;
        totalVal2 += value2;
    }
    
    if (remWeight - weight1 >= 0)
    {
        remWeight -= weight1;
        totalVal2 += value1;
    }   
}

return totalVal1 > totalVal2 ? totalVal1 : totalVal2;
