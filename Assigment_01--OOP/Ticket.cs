using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_01__OOP
{
    internal class Ticket
    {
        public string MovieName { get; set; }
        public TicketType Type { get; set; }
        public Seat seat;
        private double Price = 200;

        public Ticket(string movieName, TicketType type, Seat seat, double price)
        {
            MovieName = movieName;
            Type = type;
            this.seat = seat;
            Price = price;

        }
        public Ticket(string movieName) : this(movieName, TicketType.Standard, new Seat(), 50)
        {

        }
        public Ticket()
        {

        }

        public double CalcTotal(double taxPercent)
        {
            return Price + (Price * taxPercent);
        }

        public void ApplyDiscount(ref double discountAmount)
        {
            if (discountAmount > 0 && discountAmount <= Price)
            {
                Console.WriteLine($"============After Discount=========== ");
                Console.WriteLine($"Discount Before : {discountAmount}");
                Console.WriteLine($"Discount After : {discountAmount = 0}");
                Console.WriteLine($"Movie : {MovieName}");
                Console.WriteLine($"Discount After : {Type}");

            }
            else
            {
                Console.WriteLine($"Non Valid Discount");

            }

        }

        public void PrintTicket()

        {
            Console.WriteLine("======== TICKET INFO =========");
            Console.WriteLine($"Movie : {MovieName} ");
            Console.WriteLine($"Type : {Type} ");
            // Console.WriteLine($"Seat : {seat.Row} ");
            Console.WriteLine($"Seat : {seat.RowandSeatNumber()} ");
            Console.WriteLine($"Price : {Price} ");
            Console.WriteLine($"Total(14% tax) : {CalcTotal(0.14)} ");


        }
    }
}
