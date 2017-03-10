﻿/*
 Dim4ou is a famous BG rapper who was one day accidentally hit by a thunderbolt. From that day on Dim4ou started seeing everything in numbers, but not in black and green as Neo from the Matrix and instead in black and yellow (as Wiz Khalifa). What Dim4ou encountered is that these numbers are actually the price of gold ($$$).

As he knows the price of gold ounce for the next N days you need to help him maximize the potential profit. What you can do on each day is to either buy one ounce, sell any number of ounces that you already own, or not make any transaction at all. Your end goal is to calculate the maximum profit you and Dim4ou can obtain with an optimal trading strategy.

Input

Input is read from the console
On the first line in the console is a number N denoting the N days for which you will know the price per ounce.
The second line contains N integers separated by white space, denoting the predicted price per gold ounce for the next N days.
Output

Output should be printed on the console
A single line denoting the maximum profit which can be obtained.
Constraints

1 <= N <= 50000
1 <= price per ounce <= 100000
Time limit: 0.1s
Memory limit: 16 MB
*/

using System;
using System.Linq;

namespace GoldFever
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine().Trim());
            var nums = Console.ReadLine().Trim().Split().Select(ulong.Parse).ToArray();

            var result = maxProfit(nums);

            Console.WriteLine(result);
        }

        static ulong maxProfit(ulong[] price)
        {
            ulong result = 0;
            ulong bestPrice = 0;

            for (int i = price.Length - 1; i >= 0; i--)
            {
                if (price[i] > bestPrice)
                {
                    bestPrice = price[i];
                }

                result += bestPrice - price[i];
            }

            return result;
        }
    }
}