using System;
using System.Collections.Generic;

namespace SolveMeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[] { 1, 2, 3, 4, 10, 11 }; //Expected Result: 31
            Console.WriteLine(myfunc(ar));
            Console.ReadLine();
        }
        private static int myfunc(int[] ar)
        {
            int sum = 0;
            foreach (var item in ar)
            {
                sum += item;
            }
            return sum;
        }
    }
}
