using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesbyMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[] { 6, 5, 2, 3, 5, 2, 2, 1, 1, 5, 1, 3, 3, 3, 5};
            int n = 15;
            Console.WriteLine(myfunc(n, ar));
            Console.ReadLine();
        }

        private static int myfunc(int n, int[] ar)
        {
            Dictionary<int, int> mydic = new Dictionary<int, int>();
            for (int j = 0; j < n - 1; j++)
            {
                int ikey = ar[j];
                int ivalue;
                int counter = 1;
                for (int i = 0; i < n - 1; i++)
                {
                    if (ar[j] == ar[i]) continue;
                    else if (ikey == ar[i])
                    {
                        counter++;
                    }
                }
                ivalue = counter / 2;
                if (!mydic.ContainsKey(ikey))
                {
                    mydic.Add(ikey, ivalue);
                }
            }
            int sum = 0;
            foreach (var item in mydic)
            {
                sum += item.Value;
            }
            return (sum);
        }
    }
}
