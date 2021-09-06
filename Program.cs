using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        int j = 0;
        int TempMin = 0;

        string[] inputs = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            int t = int.Parse(inputs[i]);// a temperature expressed as an integer ranging from -273 to 5526

            // If 0 is the first value, replace TempMin by t
            if (j == 0)
            {
                TempMin = t;
            }
            // If t is less than previous temp (TempMin), replace TempMin by this t;
            if (Math.Abs(t) < Math.Abs(TempMin))
            {
                TempMin = t;
            }
            // If t is less than previous temp (TempMin), replace TempMin by t == 0;
            if (Math.Abs(t) == Math.Abs(TempMin) && t > TempMin)
            {
                TempMin = t;
            }
            j++;
        }
        Console.WriteLine(TempMin);
    }
}
