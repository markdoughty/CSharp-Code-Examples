using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples.Basics
{
    class BasicCaculator
    {
    
        //Authors: Paul Parkes
        //A basic calculator that accepts two numbers, a mathematical operation (+, -, /, *), and verifies the input
        public static void run()
        {
            string intText1;
            string intText2;
            double double1;
            double double2;
            string operation;
            double result;

            //Takes the first integer from the console
            Console.WriteLine("Please input your first integer");
            intText1 = Console.ReadLine();

            //Attempts to convert the string (intText) input into double value (double1)
            try
            {
                double1 = double.Parse(intText1);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid input");
                double1 = 0;
                double2 = 0;
                Environment.Exit(0);
            }


            //Takes the second integer from the console
            Console.WriteLine("Please input your second integer");
            intText2 = Console.ReadLine();

            //Attempts to convert the string (intText2) input into double value (double2)
            try
            {
                double2 = double.Parse(intText2);
            }
            catch(FormatException) 
            {
                Console.WriteLine("\nInvalid input");
                double1 = 0;
                double2 = 0;
                Environment.Exit(0);
            }

            //Accepts an input from the console
            Console.WriteLine("Please input an operation '+, -, *, /'");
            operation = Console.ReadLine();

            //These are all the different operations available
            if (operation == "+")
            {
                result = double1 + double2;
                Console.WriteLine("Answer: " + result);
            }

            else if (operation == "-")
            {
                result = double1 - double2;
                Console.WriteLine("Answer: " + result);
            }

            else if (operation == "*")
            {
                result = double1 * double2;
                Console.WriteLine("Answer: " + result);
            }

            else if (operation == "/")
            {
                result = double1 / double2;
                Console.WriteLine("Answer: " + result);
            }

            else
            {
                Console.WriteLine("\ninvalid input");
            }
        }
    }
}
