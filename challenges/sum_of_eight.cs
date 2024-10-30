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
 * Problem: Sum of Eight
 *
 * Given an array of ten positive integers, find the minimum and maximum values that can be calculated by summing exactly eight of the ten integers. 
 * Print the minimum and maximum sums as a single line of two space-separated integers.
 *
 * Sample Input: 4 7 1 3 9 2 8 5 6 10
 *
 * Example Output: 36 42
 *
 * Explanation:
 *
 * The numbers are: 4, 7, 1, 3, 9, 2, 8, 5, 6, 10.
 *
 * The sums of eight numbers are:
 * Excluding 1: 4 + 7 + 3 + 9 + 2 + 8 + 5 + 6 + 10 = 54
 * Excluding 2: 4 + 7 + 1 + 3 + 9 + 8 + 5 + 6 + 10 = 53
 * Excluding 3: 4 + 7 + 1 + 9 + 2 + 8 + 5 + 6 + 10 = 52
 * Excluding 4: 7 + 1 + 3 + 9 + 2 + 8 + 5 + 6 + 10 = 51
 * Excluding 5: 4 + 7 + 1 + 3 + 9 + 2 + 8 + 6 + 10 = 50
 * Excluding 6: 4 + 7 + 1 + 3 + 9 + 2 + 8 + 5 + 10 = 49
 * Excluding 7: 4 + 1 + 3 + 9 + 2 + 8 + 5 + 6 + 10 = 48
 * Excluding 8: 4 + 7 + 1 + 3 + 9 + 2 + 5 + 6 + 10 = 47
 * Excluding 9: 4 + 7 + 1 + 3 + 2 + 8 + 5 + 6 + 10 = 46
 * Excluding 10: 4 + 7 + 1 + 3 + 9 + 2 + 8 + 5 + 6 = 45
 *
 * Minimum sum is 36 and maximum sum is 42.
 */

class Result
{
    public static void sumOfEight(List<int> numbers)
    {
        int totalSum = numbers.Sum();
        int minValue = numbers.Min();
        int maxValue = numbers.Max();
        int minSum = totalSum - maxValue;
        int maxSum = totalSum - minValue;
        Console.WriteLine($"{minSum} {maxSum}");
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(num => Convert.ToInt32(num)).ToList();
        Result.sumOfEight(numbers);
    }
}
