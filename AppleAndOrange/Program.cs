using System;
using System.Collections.Generic;
using System.Linq;

namespace AppleAndOrange
{
    class Program
    {
        static void Main(string[] args)
        {

//Sample Input 0

//7 11
//5 15
//3 2
//- 2 2 1
//5 - 6


            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int s = Convert.ToInt32(firstMultipleInput[0]);
            int t = Convert.ToInt32(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int a = Convert.ToInt32(secondMultipleInput[0]);
            int b = Convert.ToInt32(secondMultipleInput[1]);

            string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int m = Convert.ToInt32(thirdMultipleInput[0]);
            int n = Convert.ToInt32(thirdMultipleInput[1]);

            List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(a => Convert.ToInt32(a)).ToList();
            List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(o => Convert.ToInt32(o)).ToList();

            countApplesAndOranges(s, t, a, b, apples, oranges);




        }

        private static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int appleCount = 0, orCount = 0;
            foreach (var item in apples)
            {
                if ((a + item >= s) && (a + item <= t)) appleCount++;

            }

            foreach (var item in oranges)
            {
                if ((b + item >= s) && (b + item) <= t) orCount++;

            }

            Console.WriteLine(appleCount);
            Console.WriteLine(orCount);
        }
    }
}
