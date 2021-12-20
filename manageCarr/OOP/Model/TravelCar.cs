using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageCarr.Model
{
    // Tính kế thừa
    public class TravelCar : Car
    {
        public int CarSeatNumber { get; set; }
        public TravelCar()
        {
        }


        //tính đa hình
        public override void Input()
        {
            Console.WriteLine("Import Id");
            this.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Import Name");
            this.Name = Console.ReadLine();
            Console.WriteLine("Import License Plates");
            this.LicensePlates = Console.ReadLine();
            Console.WriteLine("Import Car Seat Number");
            this.CarSeatNumber = int.Parse(Console.ReadLine());
        }

        //tính đa hình
        public override void Output()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("License Plates: " + LicensePlates);
            Console.WriteLine("Car Seat Number: " + CarSeatNumber);
        }
    }
}
