using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double countStandardTickets = 0;
            double countStudentTickets = 0;
            double countKidTickets = 0;

            while (command != "Finish")
            {
                int seats = int.Parse(Console.ReadLine());

                double soldTickets = 0;

                for (int i = 1; i <= seats; i++)
                {
                    string seatType = Console.ReadLine();

                    if (seatType == "End")
                    {
                        break;
                    }
                    else if (seatType == "student")
                    {
                        countStudentTickets++;
                    }
                    else if (seatType == "standard")
                    {
                        countStandardTickets++;
                    }
                    else if (seatType == "kid")
                    {
                        countKidTickets++;
                    }
                    soldTickets++;
                }

                Console.WriteLine($"{command} - {(soldTickets / seats) * 100:f2}% full.");

                command = Console.ReadLine();
            }

            double countTotalTickets = countStandardTickets + countStudentTickets + countKidTickets;

            Console.WriteLine($"Total tickets: {countTotalTickets}");
            Console.WriteLine($"{countStudentTickets / (countStandardTickets + countStudentTickets + countKidTickets) * 100:f2}% student tickets.");
            Console.WriteLine($"{countStandardTickets / (countStandardTickets + countStudentTickets + countKidTickets) * 100:f2}% standard tickets.");
            Console.WriteLine($"{countKidTickets / (countStandardTickets + countStudentTickets + countKidTickets) * 100:f2}% kids tickets.");
        }
    }
}

