/*
 Don't you like to swap? You are starting with a sequence of numbers from 1 to N. A swap around number X transforms the sequence:

<left numbers> X <right numbers>
to:

<right numbers> X <left numbers>
Your task is to perform several swap arounds.

Input

Input is read from the console
A number N is read from the first input line
A sequence of numbers - swap around each of them from left to right
Output

Output should be printed on the console
Print the sequence after all the swapping
Separate numbers by spaces
Constraints

N <= 100 000
number of swaps <= 100 000
Time limit: 0.2s
Memory limit: 48 MB
*/

using System;
using System.Linq;

namespace Swapping
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var swapps = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var initialArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                initialArr[i] = i + 1;
            }

            for (int i = 0; i < swapps.Length; i++)
            {
                initialArr = Swapps(initialArr, swapps[i]);
            }
            Console.WriteLine(string.Join(" ", initialArr));
        }

        public static int[] Swapps(int[] arr, int num)
        {
            var result = new int[arr.Length];
            int index = Array.IndexOf(arr, num);
            int index2 = index + 1;
            var temp1 = new int[index];
            var temp2 = new int[arr.Length - index2];

            for (int i = 0; i < index; i++)
            {
                temp1[i] = arr[i];
            }

            for (int i = 0; i < arr.Length - index2; i++)
            {
                temp2[i] = arr[i + index2];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (i < temp2.Length)
                {
                    result[i] = temp2[i];
                }
                if (i == temp2.Length)
                {
                    result[i] = num;
                }
                if (i > temp2.Length)
                {
                    result[i] = temp1[i - temp2.Length - 1];
                }
            }

            return result;
        }
    }
}