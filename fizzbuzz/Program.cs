using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type the number you want to fizzbuzz to");
            try
            {
                string streind = Console.ReadLine();
                int inteind = int.Parse(streind);

                for (int i = 1; i < inteind; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("fizzbuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }

                }
            }
            catch { Console.WriteLine("oh no there is something wrong please try again"); }
            }
        }
    }

