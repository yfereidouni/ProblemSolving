using System;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = "UDDDUDUU";
            //int steps = 8;
            //expected result : 1

            string path = "DUDUUUUUUUUDUDDUUDUUDDDUUDDDDDUUDUUUUDDDUUUUUUUDDUDUDUUUDDDDUUDDDUDDDDUUDDUDDUUUDUUUDUUDUDUDDDDDDDDD";
            int steps = 100;
            //expected result : 2
            Console.WriteLine(myfunc(steps, path).ToString());
        }

        private static int myfunc(int steps, string path)
        {
            bool kuh = false;
            bool dareh = false;
            int level = 0;
            int counter = 0;
            for (int i = 0; i < path.Length; i++)
            {
                if (level == 0)
                {
                    if (path[i] == 'U' && !kuh)
                    {
                        level++;
                        kuh = true;
                        if (level == 0)
                        {
                            kuh = false;
                            dareh = false;
                            counter++;
                        }
                        continue;
                    }
                    if (path[i] == 'D' && !dareh)
                    {
                        level--;
                        dareh = true;
                        if (level == 0)
                        {
                            kuh = false;
                            dareh = false;
                            counter++;
                        }
                        continue;
                    }
                    if (path[i] == 'U' && kuh)
                    {
                        level++;
                        if (level == 0)
                        {
                            kuh = false;
                            dareh = false;
                            counter++;
                        }
                        continue;
                    }
                    if (path[i] == 'D' && dareh)
                    {
                        level--;
                        if (level == 0)
                        {
                            kuh = false;
                            dareh = false;
                            counter++;
                        }
                        continue;
                    }
                    if (path[i] == 'U' && dareh)
                    {
                        level++;
                        if (level == 0)
                        {
                            kuh = false;
                            dareh = false;
                            counter++;
                        }
                        continue;
                    }
                    if (path[i] == 'D' && kuh)
                    {
                        level--;
                        if (level == 0)
                        {
                            kuh = false;
                            dareh = false;
                        }
                        continue;
                    }
                }
                else
                {
                    if (kuh)
                    {
                        if (path[i] == 'U')
                        {
                            level++;
                            if (level == 0)
                            {
                                kuh = false;
                                dareh = false;
                                counter++;
                            }
                            continue;
                        }
                        if (path[i] == 'D')
                        {
                            level--;
                            if (level == 0)
                            {
                                kuh = false;
                                dareh = false;
                            }
                            continue;
                        }
                    }
                    else
                    {
                        if (path[i] == 'U')
                        {
                            level++;
                            if (level == 0)
                            {
                                kuh = false;
                                dareh = false;
                                counter++;
                            }
                            continue;
                        }
                        if (path[i] == 'D')
                        {
                            level--;
                            if (level == 0 && kuh)
                            {
                                kuh = false;
                                dareh = false;
                            }
                            continue;
                        }
                    }
                }
            }
            return counter;
        }
    }
}
