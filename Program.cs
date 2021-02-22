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
         Console.WriteLine("What would you like instead of 3?");
         string three = Console.ReadLine();
         Console.WriteLine("What would you like instead of 5?");
         string five = Console.ReadLine();
         Console.WriteLine("What would you like instead of 13?");
         string thirteen = Console.ReadLine();
            for (int i = 1; i <= num; i++)
            {
                List<string> print = new List<string>();
                if (i % 3 == 0)
                {
                   print.Add(three);
                }
                if (i % 5 == 0)
                {
                    print.Add(five);
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
                            print.Insert(j, thirteen);
                            break;
                        }
                        if (j == print.Count - 1)
                        {
                            print.Add(thirteen);
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
