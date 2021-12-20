using manageCarr.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageCarr
{
    public class Menu : IMenu
    {
        Dictionary<int, Car> listCar = new Dictionary<int, Car>();

        public void AddCar()
        {
            Console.WriteLine(" Import(truck) or (travel) to select ");
            string travel = Console.ReadLine();
            if ("travel".Equals(travel))
            {
                Console.WriteLine("Import amount Car: ");
                int amount = int.Parse(Console.ReadLine());
                for (int i = 0; i < amount; i++)
                {
                    TravelCar travelCar = new TravelCar();
                    travelCar.Input();
                    listCar.Add(travelCar.Id, travelCar);
                }
            }
            if ("truck".Equals(travel))
            {
                Console.WriteLine("Import amount Car: ");
                int amount = int.Parse(Console.ReadLine());
                for (int i = 0; i < amount; i++)
                {
                    Truck truckCar = new Truck();
                    truckCar.Input();
                    listCar.Add(truckCar.Id, truckCar);
                }
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

        public void DeleteCar(int id)
        {
            if (listCar.ContainsKey(id))
            {
                listCar.Remove(id);
            }
        }

        //sort ascending with id
        public void SortAscendingById()
        {
            var listCarOrderById = listCar.OrderBy(c => c.Key);

            foreach (var car in listCarOrderById)
            {
                car.Value.Output();
            }
        }

        //sort Descending with id
        public void SortDescendingById()
        {
            var listCarOrderById = listCar.OrderByDescending(c => c.Key);

            foreach (var car in listCarOrderById)
            {
                car.Value.Output();
            }
        }

        public void SortByName()
        {
            var listCarOrderByName = listCar.OrderBy(c => c.Value.Name);

            foreach (var car in listCarOrderByName)
            {
                car.Value.Output();
            }
        }

        public void ShowMenu()
        {
            Console.WriteLine(" 1. Add car");
            Console.WriteLine(" 2. Display Car");
            Console.WriteLine(" 3. Find Car with id");
            Console.WriteLine(" 4. Delete Car with id");
            Console.WriteLine(" 5. Sort ascending by id");
            Console.WriteLine(" 6. Sort descending by id");
            Console.WriteLine(" 7. Sort by name");
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
                        Console.WriteLine("Import your IdCar want find");
                        int idCarRequest = int.Parse(Console.ReadLine());
                        FindCar(idCarRequest);
                        break;
                    case 4:
                        Console.WriteLine("Import your IdCar want delete");
                        int idCar = int.Parse(Console.ReadLine());
                        DeleteCar(idCar);
                        break;
                    case 5:
                        SortAscendingById();
                        break;
                    case 6:
                        SortDescendingById();
                        break;
                    case 7:
                        SortByName();
                        break;
                    default:
                        break;
                }
            } while (select != 8);
        }
    }
}
