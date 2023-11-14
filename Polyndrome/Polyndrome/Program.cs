using System;
using System.Collections.Generic;
using System.Text;

namespace Polyndrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            var inputString = Console.ReadLine();

            Stack<string> inputCharStack = new Stack<string>();

            for (int i = 0; i < inputString.Length; i++)
            {
                inputCharStack.Push(inputString[i].ToString());
            }

            StringBuilder outPutString = new StringBuilder();

            while(inputCharStack.Count > 0)
            {
                outPutString.Append(inputCharStack.Pop());
            }

            Console.WriteLine($"outPutString = {outPutString}");

            if(inputString.Equals(outPutString.ToString()))
            {
                Console.WriteLine("This is a polyndrome!");
            }
        }
    }
}
