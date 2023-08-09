using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples
{
    class Organizer
    {
        //Author: Oliver Cooper
        //Program that gets the firstname, lastname and age. Adds it to a list and gives the option to sort list by firstname, lastname or age.

        public static List<Person> People = new List<Person>();

        public static void run()
        {
            string userInput = "";

            while (userInput != "exit") //Loops until exit
            {
                userInput = "";

                Console.WriteLine("To add an entry type add to sort by either firstname lastname or age type sort to display the list type display or to exit type exit");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "add") //adds a new person
                {
                    add();
                    Console.Read();
                }
                else if (userInput.ToLower() == "sort") //sorts list
                {
                    sort();
                    Console.Read();
                }
                else if (userInput.ToLower() == "display") //displays list
                {
                    display();
                    Console.Read();
                }

                Console.Clear();
            }
        }

        static void add() //adds a new entry to the list
        {
            Console.Clear();

            string newEntry;
            string[] seperated;
            int age;

            Console.WriteLine("To add a new entry type in the firstname lastname and age in the format: <Firstname> <Lastname> <Age>");
            newEntry = Console.ReadLine();

            seperated = newEntry.Split(); //splits at spaces

            if (seperated.Length != 3) // checks for 3 words
            {
                Console.WriteLine("Error: You must input in the format <Firstname> <Lastname> <Age>");
                return;
            }
            if (int.TryParse(seperated[2], out _) == false) //checks if 3rd is integar
            {
                Console.WriteLine("Error: Age must be a number");
                return;
            }

            age = int.Parse(seperated[2]); //converts 3rd to integar

            People.Add(new Person(seperated[0], seperated[1], age)); //ads new entry to list

            Console.WriteLine("Added");
            return;
        }

        static void sort() //sorts the list by either firstname lastname or age
        {
            Console.Clear();

            string choice;

            Console.WriteLine("Choose either Firstname, Lastname or Age:");
            choice = Console.ReadLine();

            if (choice.ToLower() == "firstname") //sort by first name
            {
                People = People.OrderBy(p => p.FirstName).ToList();
                Console.WriteLine("Sorted");
                return;
            }

            if (choice.ToLower() == "lastname") //sort by last name
            {
                People = People.OrderBy(p => p.LastName).ToList();
                Console.WriteLine("Sorted");
                return;
            }

            if (choice.ToLower() == "age") //sort by age
            {
                People = People.OrderBy(p => p.Age).ToList();
                Console.WriteLine("Sorted");
                return;
            }

            Console.WriteLine("Error: Not a choice"); //validation
            return;
        }

        static void display() //displays current list
        {
            Console.Clear();

            if (People.Count() == 0) //if there are no entries in list returns error
            {
                Console.WriteLine("Error: The list is empty");
                return;
            }

            foreach (var Person in People) //prints first and last name and age of each element in list
            {
                Console.WriteLine(Person.FirstName + " " + Person.LastName + " " + Person.Age);
            }

            return;
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
