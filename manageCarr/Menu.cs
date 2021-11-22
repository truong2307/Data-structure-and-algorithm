using manageCarr.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageCarr
{
    public class Menu
    {
        Dictionary<int, Car> listCar = new Dictionary<int, Car>();

        public void AddCar()
        {
            Console.WriteLine("Import amount Car: ");
            int amount = int.Parse(Console.ReadLine());
            for (int i = 0; i < amount; i++)
            {
                TravelCar travelCar = new TravelCar();
                travelCar.Input();
                listCar.Add(travelCar.Id,travelCar);
            }
        }

        public void GetCar()
        {
            foreach (var car in listCar.Values)
            {
                car.Output();
                Console.WriteLine("-------------------");
            }
        }

        public void FindCar(int id)
        {
            if (listCar.ContainsKey(id))
            {
                listCar[id].Output();
            }
        }

        public void ShowMenu()
        {
            Console.WriteLine(" 1. Add car");
            Console.WriteLine(" 2. Display Car");
            Console.WriteLine(" 2. Find Car with id");
        }
        public void SelectFeature()
        {
            int select;
            do
            {
                ShowMenu();
                Console.WriteLine(" Select feature ");
                select = int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        AddCar();
                        break;
                    case 2:
                        GetCar();
                        break;
                    case 3:
                        Console.WriteLine("Import your IdCar");
                        int idCarRequest = int.Parse(Console.ReadLine());
                        FindCar(idCarRequest);
                        break;
                    default:
                        break;
                }
            } while (select != 2);
        }
    }
}
