using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    public class FreeSoftware : ISoftware
    {
        protected string name;
        protected string manufacturer;

        public FreeSoftware(string name, string manufacturer)
        {
            this.name = name;
            this.manufacturer = manufacturer;
        }

        public void DisplaySoftwareInfo()
        {
            Console.WriteLine($"Name: {name}, Manufacturer: {manufacturer}");
        }

        public bool CanUse(DateTime currentDate)
        {
            // Вільне програмне забезпечення можна використовувати завжди
            return true;
        }
    }
}
