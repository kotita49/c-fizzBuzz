using System;
using System.Collections.Generic;

namespace c_FizzBuzz
{
    class Program
    {
     
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
        int num = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                List<string> print = new List<string>();
                if (i % 3 == 0)
                {
                    print.Add("Fizz");
                }
                if (i % 5 == 0)
                {
                    print.Add("Buzz");
                }
                if (i % 7 == 0)
                {
                    print.Add("Bang");
                }
                if (i % 11 == 0)
                {
                    print.Add("Bong");
                }
                if (i % 13 == 0)
                {
                    for (var j = 0; j < print.Count; j++)
                    {
                        if (print[j].StartsWith("B") && i % 13 == 0)
                        {
                            print.Insert(j, "Fezz");
                            break;
                        }
                        if (j == print.Count - 1)
                        {
                            print.Add("Fezz");
                            break;
                        }
                    }
                }
                if (print.Count == 0)
                {
                    print.Add(i.ToString());
                }
                String newPrint = String.Join("", print);
                Console.WriteLine(newPrint);
            }
        }
    }
}
