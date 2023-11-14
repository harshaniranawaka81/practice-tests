// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var subStrings = new List<String>();

string S = "aaabccdeggg";
var prevChar = S[0];
String tmp;
int startIndex = 0;

for (int i = 0; i < S.Length; i++)
{
    //String tmp = S.Substring(0, i);    

    if (S[i] == prevChar)
    {
        tmp = S.Substring(startIndex, i - startIndex);

        if (!string.IsNullOrEmpty(tmp))
        {
            subStrings.Add(tmp);
        }

        startIndex = i;
    }
    
    prevChar = S[i];
}

subStrings = subStrings.Distinct().ToList();

var distinctChars = S.Distinct().ToList();

var distinctStrings = new List<string>();

for (int i = 0; i < distinctChars.Count; i++)
{
    foreach (var item in subStrings)
    {
        var count = item.Count(x => x == distinctChars[i]);
        if (count == 1)
        {
            if (!distinctStrings.Contains(item))
            {
                distinctStrings.Add(item);
            }
        }
    }   
}

foreach (var item in distinctStrings)
{
    Console.WriteLine(item);
}

