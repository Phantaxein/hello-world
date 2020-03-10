using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            FizzBuzz(number);
            Console.ReadKey();
        }
        /*
         * This program will recieve int X and print all numbers from 1-x 
         * (if x is 3 it would say:
         * 1
         * 2
         * 3)
         * 
         * Here's the catch: \
         * Numbers that are divisible by 3 will be replaced with Fizz
         * Numbers that are divisible by 5 will be replaced with Buzz
         * Numbers that are divisible by both will be replaced with FizzBuzz
         * 
         */
        static void FizzBuzz(int x)
        {
            int countBuzz = 1;
            int countFizz = 1;
            int countFizzBuzz = 1;
            string stringBuzz = "Buzz";
            string stringFizz = "Fizz";
            string stringFizzBuzz = "FizzBuzz";
            for (int i = 0; i < x; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(stringFizzBuzz + " Current FizzBuzzes: " + countFizzBuzz);
                    stringFizzBuzz = stringFizzBuzz + "FizzBuzz";
                    countFizzBuzz++;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(stringFizz + " Current Fizzes: " + countFizz);
                    stringFizz = stringFizz + "Fizz";
                    countFizz++;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(stringBuzz + " Current Buzzes: " + countBuzz);
                    stringBuzz = stringBuzz + "Buzz";

                    countBuzz++;
                }
            }
            Console.WriteLine("Buzz Total: " + (countBuzz - 1));
            Console.WriteLine("Fizz Total: " + (countFizz - 1));
            Console.WriteLine("FizzBuzz Total: " + (countFizzBuzz - 1));

        }
    }
}
