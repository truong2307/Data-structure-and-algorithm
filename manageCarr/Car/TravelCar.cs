using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageCarr.Car
{
    public class TravelCar :Car
    {
        public int CarSeatNumber { get; set; }
        public TravelCar(int id, string name, string licensePlates, int carSeatNumber) : base(id,name,licensePlates)
        {
            this.CarSeatNumber = carSeatNumber;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Import Car Seat Number");
            this.CarSeatNumber = int.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Car Seat Number" +CarSeatNumber);
        }
    }
}
