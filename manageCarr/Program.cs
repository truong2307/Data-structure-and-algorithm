using System;
using System.Text;

namespace manageCarr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Menu menu = new Menu();
            menu.SelectFeature();
        }
    }
}
