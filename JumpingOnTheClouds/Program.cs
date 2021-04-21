using System;
using System.Collections.Generic;

namespace JumpingOnTheClouds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            //int[] c = new int[] { 0, 0, 1, 0, 0, 1, 0 }; //Expected Result: 3
            //int[] c = new int[] { 0, 0, 0, 1, 0, 0 }; //Expected Result: 3
            //int[] c = new int[] { 0, 0, 1, 0, 0, 1, 0 }; //Expected Result: 4
            int[] c = new int[] { 0, 0, 0, 1, 0, 0 }; //Expected Result: 3
            Console.WriteLine(myfunc(n, c));
            Console.ReadLine();
        }

        private static int myfunc(int n, int[] c)
        {
            List<int> path = new List<int>() { };

            int i = 0;
            path.Add(i);

            while (i <= c.Length - 2)
            {
                if (i < c.Length - 2)
                {
                    if (c[i + 1] == 0 && c[i + 2] == 0)
                    {
                        path.Add(i + 2);
                        i = i + 2;
                    }
                    else if (c[i + 1] != 0 && c[i + 2] == 0)
                    {
                        path.Add(i + 2);
                        i = i + 2;
                    }
                    else if (c[i + 1] == 0 && c[i + 2] != 0)
                    {
                        path.Add(i + 1);
                        i = i + 1;
                    }
                }
                if (i == c.Length - 2)
                {
                    if (c[i + 1] == 0)
                    {
                        path.Add(i + 1);
                        i = i + 1;
                        break;
                    }
                }
            }
            return (path.Count)-1;
        }
    }
}