using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;

namespace MajorityElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 2, 1, 2, 1, 1, 2, 2 };

            Dictionary<int, int> values = new();

            for (int i = 0; i < input.Length; i++)
            {
                var count = input.Count(x => x == input[i]);

                if(values.ContainsKey(input[i]))
                {
                    values[input[i]] = count;
                }
                else
                {
                    values.Add(input[i], count);
                }
            }

            var majorityValue = Math.Floor((decimal)input.Length / 2);
            var majority = values.First(k => k.Value > majorityValue).Key;

            Console.WriteLine($"Majority = {majority}");

        }
    }
}
