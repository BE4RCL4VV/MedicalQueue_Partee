using System;
using System.Collections.Generic;
using System.Threading;

namespace MedicalQueue_Partee
{
    class Program
    {
        static void Main(string[] args)
        {
            ERQueue queue = new ERQueue();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("(A)dd Patient. (P)rocess Current Patient. (L)ist All in Queue. (Q)uit");
                ConsoleKeyInfo keyPress = Console.ReadKey();
// Add
                if (keyPress.Key == ConsoleKey.A)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter the Patients First Name and Priority");
                    Console.WriteLine("First Name: ");
                    string first = Console.ReadLine();
                    //Console.WriteLine("Last Name: ");
                    //string last = Console.ReadLine();
                    Console.WriteLine("Priority level: (1: Highest Priority – 5: Lowest Priority)");
                    int priority = int.Parse(Console.ReadLine());
                    queue.AddPatient(new Patient(first, /*last,*/ priority));
                    Console.WriteLine(first + " added to Queue at Priority: " + priority);
                    Console.WriteLine("Press Enter to Continue");
                    Console.ReadLine();

                }
// Process
                if (keyPress.Key == ConsoleKey.P)
                {
                    Console.Clear();                   
                    Console.WriteLine(queue.getHead().FirstName + " was Processed:");
                    queue.RemovePatient(queue.getHead());
                    Console.WriteLine("Press Enter to Continue");
                    Console.ReadLine();                  
                }
// List
                if (keyPress.Key == ConsoleKey.L)
                {
                    Console.Clear();
                    queue.ListPatients();
                    Console.WriteLine("Press Enter to Continue");
                    Console.ReadLine();
                }
//Quit
                if (keyPress.Key == ConsoleKey.Q)
                {
                    Console.Clear();
                    Console.WriteLine("Good-Bye...");
                    Thread.Sleep(2000);
                    break;
                }
            }

        }
        
    }
}
