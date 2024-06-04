using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JisaProgramms
{
    internal class Climbstairs
    {
        public static int WaysToClimbStairs(int n)
        {
            if (n <= 1)
            {
                return 1; // There is only one way to climb 0 or 1 step (no steps or one step at a time).
            }

            int[] ways = new int[n + 1];
            ways[0] = 1;
            ways[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                // The number of ways to climb the current step is the sum of ways to climb the previous two steps.
                ways[i] = ways[i - 1] + ways[i - 2];
            }

            return ways[n];
        }

        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = WaysToClimbStairs(n);
            Console.WriteLine(result);

        }
    }
}
