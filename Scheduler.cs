using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples
{
    public class Scheduler
    {

        static List<Appointment> appointments = new List<Appointment>();

        public static void run()
        {
            while (true)
            {
                Console.WriteLine("Appointment Scheduler");
                Console.WriteLine("1. Schedule Appointment");
                Console.WriteLine("2. View Appointments");
                Console.WriteLine("3. Update Appointment");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");
                string input = Console.ReadLine();

                switch (input)
                {
                case "1":
                    ScheduleAppointment();
                    break;
                case "2":
                    ViewAppointments();
                    break;
                case "3":
                    UpdateAppointment();
                    break;
                case "4":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
                }
            }
        }

        public static void ScheduleAppointment()
        {
            Console.Write("Enter appointment Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter appointment date (YYYY-MM-DD): ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime date))
            {
                Console.WriteLine("Invalid date format. Appointment not scheduled.");
                return;
            }

            Console.Write("Enter appointment time (HH:mm): ");
            if (!TimeSpan.TryParse(Console.ReadLine(), out TimeSpan time))
            {
                Console.WriteLine("Invalid time format. Appointment not scheduled.");
                return;
            }

            Console.Write("Enter appointment location: ");
            string location = Console.ReadLine();

            appointments.Add(new Appointment(title, date, time, location));
            Console.WriteLine("Appointment scheduled successfully.");
        }

        static void ViewAppointments()
        {
            if (appointments.Count == 0)
            {
                Console.WriteLine("No appointments scheduled.");
            }
            else
            {
                Console.WriteLine("Scheduled Appointments:");
                for (int i = 0; i < appointments.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {appointments[i]}");
                }
            }
        }


        static void UpdateAppointment()
        {
            if (appointments.Count == 0)
            {
                Console.WriteLine("No appointments scheduled.");
                return;
            }

            ViewAppointments();
            Console.Write("Enter the appointment number to update: ");
            if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > appointments.Count)
            {
                Console.WriteLine("Invalid appointment number. Update cancelled.");
                return;
            }

            Appointment selectedAppointment = appointments[index - 1];

            Console.WriteLine($"Editing Appointment: {selectedAppointment}");
            Console.Write("Enter appointment title (leave empty to keep the same): ");
            string title = Console.ReadLine();
            if (!string.IsNullOrEmpty(title))
            {
                selectedAppointment.Title = title;
            }

            Console.Write("Enter appointment date (YYYY-MM-DD) (leave empty to keep the same): ");
            string dateString = Console.ReadLine();
            if (!string.IsNullOrEmpty(dateString) && DateTime.TryParse(dateString, out DateTime date))
            {
                selectedAppointment.Date = date;
            }

            Console.Write("Enter appointment time (HH:mm) (leave empty to keep the same): ");
            string timeString = Console.ReadLine();
            if (!string.IsNullOrEmpty(timeString) && TimeSpan.TryParse(timeString, out TimeSpan time))
            {
                selectedAppointment.Time = time;
            }

            Console.Write("Enter appointment location (leave empty to keep the same): ");
            string location = Console.ReadLine();
            if (!string.IsNullOrEmpty(location))
            {
                selectedAppointment.Location = location;
            }

            Console.WriteLine("Appointment updated successfully.");
        }



    public class Appointment
    {
        public string Title{ get; set; }
        public DateTime Date{ get; set; }
        public TimeSpan Time{ get; set; }
        public string Location{ get; set; }


            public Appointment(string title, DateTime date, TimeSpan time, string location)
        {
            Title = title;
            Date = date;
            Time = time;
            Location = location;
        }

        public override string ToString()
        {
            return $"{Title} | Date: {Date.ToShortDateString()} | Time: {Time.ToString(@"hh\:mm")} | Location: {Location}";
        }
    }
}
