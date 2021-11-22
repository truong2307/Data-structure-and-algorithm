using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageCarr.Model
{
    public class Truck : Car
    {
        public int Weight { get; set; }
        public Truck()
        {

        }
        public Truck(int id, string name, string licensePlates,int weight) : base(id,name,licensePlates)
        { }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Import Car Weight");
            this.Weight = int.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Car Weight: " + Weight);
        }
    }
}
