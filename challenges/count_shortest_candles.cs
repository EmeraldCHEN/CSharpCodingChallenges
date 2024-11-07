using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

/*
 * Problem: Count Shortest Candles
 *
 * You are helping to organize a candle display for a birthday party. 
 * Each candle has a different height, and you want to know how many candles have the shortest height.  
 * The number of candles is determined by the child's age, and you are given a list of integers representing the heights of these candles.
 *
 * Sample Input: 
 * 5
 * 4 2 3 1 2
 *
 * Sample Output: 1
 *
 * Explanation:
 *
 * Explanation:
 * The shortest candle has a height of 1, and there is one candle with height 1. So, the output is 1.
 */

class Result
{
    public static int countShortestCandles(List<int> candles)
    {
        // Step 1: Find the maximum height among the candles
        int shortest = candles[0];  // Assume the first candle is the shortest initially
        foreach (int candle in candles)
        {
            if (candle < shortest)
            {
                shortest = candle;  // Update shortest if a shorter candle is found
            }
        }

        // Step 2: Count how many candles have the shortest height
        int count = 0;
        foreach (int candle in candles)
        {
            if (candle == shortest)
            {
                count++;  
            }
        }
        return count;

    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = Result.countShortestCandles(candles);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
