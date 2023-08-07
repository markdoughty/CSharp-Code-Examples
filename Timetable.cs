using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples
{
    public class Timetable
    {
        // Authors: Deividas Milinskas
        // This Code will ask the user for their weekly lessons and turn it into a timetable for them
        public static void run()
        {
            // Array to hold the days of the week
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};

            // Dictionary to store schedule details for each day
            Dictionary<string, List<(string room, string startTime, string endTime, string module)>> schedule = new Dictionary<string, List<(string, string, string, string)>>();

            Console.WriteLine("Enter schedule details for each day of the week (enter 'done' to finish):\n");

            foreach (var day in daysOfWeek)
            {
                // Create a list to store multiple entries for the same day
                schedule.Add(day, new List<(string, string, string, string)>());

                Console.WriteLine($"--- {day} ---");

                while (true)
                {
                    Console.Write("Enter location (or 'done' to finish): ");
                    string room = Console.ReadLine();

                    if (room.ToLower() == "done")
                        break;

                    string startTime;
                    while (true)
                    {
                        Console.Write("Enter start time (HH:mm format): ");
                        startTime = Console.ReadLine();

                        // Check if the entered time is in valid format
                        if (IsValidTimeFormat(startTime))
                            break;
                        else
                            Console.WriteLine("Invalid time format. Please enter time in HH:mm format.");
                    }

                    string endTime;
                    while (true)
                    {
                        Console.Write("Enter end time (HH:mm format): ");
                        endTime = Console.ReadLine();

                        // Check if the entered time is in valid format
                        if (IsValidTimeFormat(endTime))
                            break;
                        else
                            Console.WriteLine("Invalid time format. Please enter time in HH:mm format.");
                    }

                    Console.Write("Enter module: ");
                    string module = Console.ReadLine();

                    // Add the entry to the schedule dictionary
                    schedule[day].Add((room, startTime, endTime, module));
                    Console.WriteLine();
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nYour weekly schedule:");

            foreach (var day in daysOfWeek)
            {
                Console.WriteLine($"--- {day} ---");

                if (schedule[day].Count == 0)
                {
                    Console.WriteLine("No entries for this day.");
                }
                else
                {
                    Console.WriteLine("+------------+------------+------------+------------+------------+");
                    Console.WriteLine("|   Room     | Start Time |  End Time  |   Module   |");
                    Console.WriteLine("+------------+------------+------------+------------+------------+");

                    foreach (var entry in schedule[day])
                    {
                        Console.WriteLine($"| {entry.Item1,-10} | {entry.Item2,-10} | {entry.Item3,-10} | {entry.Item4,-10} |");
                    }

                    Console.WriteLine("+------------+------------+------------+------------+------------+");
                }

                Console.WriteLine();
            }
        }

        // Function to check if the entered time is in valid "HH:mm" format
        static bool IsValidTimeFormat(string time)
        {
            return DateTime.TryParseExact(time, "HH:mm", null, System.Globalization.DateTimeStyles.None, out _);
        }
    }
}

