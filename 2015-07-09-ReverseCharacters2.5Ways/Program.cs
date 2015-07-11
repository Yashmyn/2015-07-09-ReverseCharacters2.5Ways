using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015_07_09_ReverseCharacters2._5Ways
{
    class Program
    {
        static void Main(string[] args)
        {

            //reverse a string in (not really 3, but rather) 2.5 ways

            Console.Write("Please enter a string, and I will reverse it: ");

            string input = Console.ReadLine();

            string output = "";

            //reverse a string using both "input" and "output" variables

            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }
            Console.WriteLine();
            Console.WriteLine("The reversed string, using 'input' and 'output' variables:");
            Console.WriteLine(output);
            Console.WriteLine();

            //reverse the string using only an "input" variable

            Console.WriteLine("The reversed string again, using only an 'input' variable:");

            for (int i = input.Length - 1; i >= 0; i--)
                Console.Write(input[i]);
            Console.WriteLine();
            Console.WriteLine();


            //reverse the string using Array.Reverse

            Console.WriteLine("The reversed string a third time, using Array.Reverse:");

            char[] inputArray = input.ToCharArray();
            Array.Reverse(inputArray);
            output = new string(inputArray);
            Console.WriteLine(output);
            Console.ReadLine();


        }
    }
}
