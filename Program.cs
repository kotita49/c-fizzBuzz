﻿using System;

namespace c_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)  
{ 
    string print = "";
                 if(i%3==0){
                     print += "Fizz";
            } if(i%5==0){
                print += "Buzz";
            }if(print.Length == 0){
                print = i.ToString();
            }
        
            Console.WriteLine(print);
            }
                 
        }
        
    }
        }
    

