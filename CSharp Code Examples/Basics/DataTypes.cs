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


                        try // error handles whether the correct data type is inserted
                        {
                        Console.WriteLine("Enter the first int: ");
                        int num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the second int: ");
                        int num2 = int.Parse(Console.ReadLine());
                        int result = num1+ num2;
                        Console.WriteLine("Result: " +result);

                        }
                        catch (Exception ex) 
                        {
                           Console.WriteLine(ex.Message);
                           
                        }
                

                        break;

                    case "array": // displays the vehicle types

                        try
                        {
                            string[] newstringarray = new string[4];

                            //data is created and stored in the array values
                            newstringarray[0] = "Scooter";
                            newstringarray[1] = "Boat";
                            newstringarray[2] = "Bike";
                            newstringarray[3] = "car";

                            Console.WriteLine("Select a vehicle from 1 to 5 (5 is all of the vehicles)");

                            int choose = int.Parse(Console.ReadLine());

                            if (choose == 1)
                            {
                                Console.WriteLine("Vehicle type: " + newstringarray[0]);
                            }
                            if (choose == 2)
                            {
                                Console.WriteLine("Vehicle type: " + newstringarray[1]);
                            }
                            if (choose == 3)
                            {
                                Console.WriteLine("Vehicle type: " + newstringarray[2]);
                            }
                            if (choose == 4)
                            {
                                Console.WriteLine("Vehicle type: " + newstringarray[3]);
                            }
                            if (choose == 5)
                            {
                                for (int i = 0; i < newstringarray.Length; i++)
                                {
                                Console.WriteLine("Vehicle type: " +  newstringarray[i]);
                                }
                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
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
