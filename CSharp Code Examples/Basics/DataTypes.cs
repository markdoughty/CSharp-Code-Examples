using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples
{
    class DataTypes
    {
        //Authors: Ryan Barber
        //The user will be able to select from a vast of data types and will print what is requested
        public static void run()
        {
          
            
            bool exit = false; // program running

            while (!exit)
            {
                Console.WriteLine("Enter a command (type 'exit' to quit):");
                string input = Console.ReadLine(); // userinput

                switch (input.ToLower())
                {
                    case "help":
                        Console.WriteLine("List of available commands: int, array and string");
                        break;

                    case "int": // add two numbers together

                        Console.WriteLine("Enter the first int: ");
                        int num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the second int: ");
                        int num2 = int.Parse(Console.ReadLine());

                        int result = num1+ num2;
                        Console.WriteLine("Result: " +result);

                        break;

                    case "array": // displays the vehicle types

                        string[] newstringarray = new string[4];

                        newstringarray[0] = "Scooter";
                        newstringarray[1] = "Boat";
                        newstringarray[2] = "Bike";
                        newstringarray[3] = "car";

                        for (int i = 0; i < newstringarray.Length; i++)
                        {
                            Console.WriteLine("Vehicle type: " +  newstringarray[i]);
                        }

                        break;

                    case "string": // displays a sentance

                        string word1 = "This is ";
                        string word2 = "gonna be a good day!";

                        Console.WriteLine(word1+ word2);

                        break;

                    case "exit":
                        exit = true;
                        break;

                    default: //error handling 
                        Console.WriteLine("Invalid command. Type 'help' for available commands.");
                        break;
                }
          
            }
        }
    }
}
