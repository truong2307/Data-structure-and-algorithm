using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageCarr.Model
{
    public class Car
    {
        public int Id { get; set; }
        private string Name { get; set; }
        private string LicensePlates { get; set; }

        public Car()
        {
        }

        public Car(int id, string name,string licensePlates)
        {
            this.Id = id;
            this.Name = name;
            this.LicensePlates = licensePlates;
        }

        public virtual void Input()
        {
            Console.WriteLine("Import Id");
            this.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Import Name");
            this.Name = Console.ReadLine();
            Console.WriteLine("Import License Plates");
            this.LicensePlates = Console.ReadLine();
        }

        public virtual void Output()
        {
            Console.WriteLine("Id: " +Id);
            Console.WriteLine("Name: " +Name);
            Console.WriteLine("License Plates: " + LicensePlates);
        }
    }
}
