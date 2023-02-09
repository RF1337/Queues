using System;
using System.Collections.Generic;

namespace Reservation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("           Welcome to the queue           ");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1. Add items\n2. Delete items\n3. Show the number of items" +
                "\n4. Show min and max items\n5. Print all items\n6. Exit");
            Console.WriteLine("\nEnter your choice: ");

            //Creating queue
            Queue<Reservation> guests = new Queue<Reservation>();
            //Adding items to queue and giving them a seat number + name
            guests.Enqueue(new Reservation() {SeatNumber = 1, Name = "Rasmus" });
            guests.Enqueue(new Reservation() { SeatNumber = 2, Name = "Silas" });
            guests.Enqueue(new Reservation() { SeatNumber = 3, Name = "Tobias" });
            guests.Enqueue(new Reservation() { SeatNumber = 4, Name = "Burak" });
            guests.Enqueue(new Reservation() { SeatNumber = 5, Name = "Mikkel" });

            //Creating a bool used to determine if user wants to exit
            bool wannaLeave = false;
            
            //Loop that executes at least once and until the user chooses to exit
            do
            {
                //Menu
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("What is your name?");
                        AddReservation();
                        break;
                    case "2":
                        Console.WriteLine("Removing first from queue");
                        guests.Dequeue();
                        break;
                    case "3":
                        Console.WriteLine("There are " + guests.Count + " reservations");
                        break;
                    case "4":
                        //Don't know how to see what the last one in the queue is
                        Console.WriteLine(guests.Peek().Name + " is gonna leave soon");
                        break;
                    case "5":
                        foreach (Reservation item in guests)
                        {
                            Console.WriteLine($"{item.SeatNumber}: {item.Name}");
                        }
                        break;
                    case "6":
                        Console.WriteLine(@"
                 _____                       _   _                    
                |  __ \                     | | | |                   
                | |  \/   ___     ___     __| | | |__    _   _    ___ 
                | | __   / _ \   / _ \   / _` | | '_ \  | | | |  / _ \
                | |_\ \ | (_) | | (_) | | (_| | | |_) | | |_| | |  __/
                 \____/  \___/   \___/   \__,_| |_.__/   \__, |  \___|
                                                          __/ |       
                                                         |___/        ");
                        wannaLeave = true;
                        break;
                    default:
                        Console.WriteLine("That is not an option");
                        break;
                }
            } while (wannaLeave == false);

            
            //Method that adds a reservation in the queue
            //uses ReadLine to add what your name is to the queue
            //uses count+=1 to find out what your seat number is gonna be
            void AddReservation()
            {
                int howManyGuests = guests.Count;
                int howManyGuests2 = howManyGuests += 1;
                guests.Enqueue(new Reservation() { SeatNumber = (byte)howManyGuests2, Name = Console.ReadLine() }); ;
            }
        }
    }
}
