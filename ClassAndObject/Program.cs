using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // membuat object Taxi
            taxi taxi = new taxi();

            // membuat nilai properti
            taxi.DriverName = "Zerick";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            // pemanggilan method
            taxi.TaxiInfo();
            taxi.PicUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
