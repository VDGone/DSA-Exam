/*
 Ah, the Rings.. they are round. They are numbered and attached to each other (see the image below).

rings1

There will be N rings numbered from 1 to N. Exactly one of the rings is on the top, all others are hanging from it. Find the number of possible configurations of the rings so that the obey the hanging rules (see input).

Example: If rings 2 and 3 are hanging from ring 1 there are 2 ways to order them (2 left of 3 and 3 left of 2).

Input

Input is read from the console
A number N is given on the first line
On each of the next N lines a number is given describing the hanging rules
which ring is ring 1 hanging from
which ring is ring 2 hanging from
...
0 means that the ring is on the top
Output

Output should be printed on the console
Print the number of ring configurations on a single line
Constraints

1 <= N <= 21
Time limit: 0.1s
Memory limit: 16 MB
 */

using System;

namespace Rings
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            int equals = 1;
            ulong result = 1;

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (i != nums.Length - 1)
                {
                    if (nums[i] == nums[i + 1])
                    {
                        equals++;
                    }
                    if ((nums[i] != nums[i + 1]))
                    {
                        result *= Factorial(equals);
                        equals = 1;
                    }
                }
                else
                {
                    result *= Factorial(equals);
                }
            }

            Console.WriteLine(result);
        }

        public static ulong Factorial(int number)
        {
            ulong result = 1;

            for (ulong i = 1; i <= (ulong)number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
