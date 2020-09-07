using System;
using System.Collections.Generic;
using System.Text;

namespace CourtBooking
{
    public class Entities
    {
        private int id;
        private string courtNumber;
        private string bookingTime;
        private string booker;

        public int Id { get => id; set => id = value; }
        public string CourtNumber { get => courtNumber; set => courtNumber = value; }
        public string BookingTime { get => bookingTime; set => bookingTime = value; }
        public string Booker { get => booker; set => booker = value; }
    }
}
