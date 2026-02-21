using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_01__OOP
{
    internal class Seat
    {
        public string Row { get; set; }
        public int Number { get; set; }
        public Seat(string row, int number)
        {
            Row = row;
            Number = number;
        }
        public Seat()
        {

            Row = "A";
            Number = 1;
        }
        public string RowandSeatNumber()
        {
            return $"{Row}{Number}";
        }
    }
}
