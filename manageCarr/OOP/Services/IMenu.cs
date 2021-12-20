using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageCarr
{
    public interface IMenu
    {
        public void AddCar();
        public void GetCar();
        public void FindCar(int id);
        public void DeleteCar(int id);
        public void SortAscendingById();
        public void SortDescendingById();
        public void SortByName();
        public void SelectFeature();
    }
}
