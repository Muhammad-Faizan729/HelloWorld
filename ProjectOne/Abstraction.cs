using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne
{
    abstract class Abstraction
    {
        public string TicketID { get; set; }
        public int Price { get; set; }
        public int SeatNumber { get; set; }
        public void PrintTicket()
        {
            Console.WriteLine("Your Ticket ID is : " + TicketID);
            Console.WriteLine("Price Per Seat : " + Price);
            Console.WriteLine("Seat Allotted : " + SeatNumber);
        }
        public abstract void CalculatePrice();
    }

    class RegularTicket : Abstraction
    {
        public override void CalculatePrice()
        {
            Price = 1000;
            Console.WriteLine("This is Regular Ticket and Total_Price is :"+ Price);
        }
    }

    class VipTicket : Abstraction
    {
        public override void CalculatePrice()
        {
            Price = 1500;
            Console.WriteLine("This is VIP Ticket and Total_Price is :"+ Price);
        }
    }

    class StudentTicket : Abstraction
    {
        public override void CalculatePrice()
        {
            Price = 2000;
            Console.WriteLine("This is Student Ticket and Total_Price is :"+ Price);
        }
    }
}
