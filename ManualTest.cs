using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace CourtBooking
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Service service = new Service();
            List<Entities> bookingList = service.getInfo();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Goddag og velkommen til alt der har at gøre med mig ;)");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1: Se alle bookings");
                Console.WriteLine("2: Vælg booking udfra id");
                Console.WriteLine("3: Vælg booking udfra booker");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Vælg: ");
                string valg =  Console.ReadLine();

                if(valg == "1")
                {
                    Console.Clear();
                    foreach (var booking in bookingList)
                    {
                        Console.WriteLine($"ID: {booking.Id} - CourtNumber: {booking.CourtNumber} - BookingTime: {booking.BookingTime} - Booker: {booking.Booker}");
                        Console.WriteLine();
                    }
                }
                else if(valg == "2")
                {
                    Console.Write("Hvilket id tænker du på? ");
                    string valg2Valg = Console.ReadLine();
                    foreach (var booking in bookingList)
                    {
                        if(booking.Id.ToString() == valg2Valg)
                        {
                            Console.Clear();
                            Console.WriteLine($"ID: {booking.Id} - CourtNumber: {booking.CourtNumber} - BookingTime: {booking.BookingTime} - Booker: {booking.Booker}");
                        }
                    }
                            
                }
                else if(valg == "3")
                {
                    Console.Write("Hvilket booker tænker du på? ");
                    string valg2Valg = Console.ReadLine();
                    foreach (var booking in bookingList)
                    {
                        if (booking.Booker.ToString() == valg2Valg)
                        {
                            Console.Clear();
                            Console.WriteLine($"ID: {booking.Id} - CourtNumber: {booking.CourtNumber} - BookingTime: {booking.BookingTime} - Booker: {booking.Booker}");
                        }
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
