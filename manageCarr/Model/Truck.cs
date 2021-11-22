using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageCarr.Model
{
    // tính kế thừa
    public class Truck : Car
    {
        public int Weight { get; set; }
        public Truck()
        {

        }
        public Truck(int id, string name, string licensePlates,int weight) : base(id,name,licensePlates)
        { }

        // tính đa hình
        public override void Input()
        {
            Console.WriteLine("Import Id");
            this.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Import Name");
            this.Name = Console.ReadLine();
            Console.WriteLine("Import License Plates");
            this.LicensePlates = Console.ReadLine();
            Console.WriteLine("Import Car Weight");
            this.Weight = int.Parse(Console.ReadLine());
        }

        // tính đa hình
        public override void Output()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("License Plates: " + LicensePlates);
            Console.WriteLine("Car Weight: " + Weight);
        }
    }
}
