using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageCarr.Model
{
    // tính trừu tượng
    public abstract class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LicensePlates { get; set; }

        public Car()
        {
        }

        // tính đóng gói
        protected Car(int id, string name,string licensePlates)
        {
            this.Id = id;
            this.Name = name;
            this.LicensePlates = licensePlates;
        }

        // tính trừu tượng
        public abstract void Input();
        public abstract void Output();
        
    }
}
