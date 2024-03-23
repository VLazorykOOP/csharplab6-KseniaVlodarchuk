using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    public class Factory : Company
    {
        protected int productionVolume;

        public Factory(string name, int year, int volume)
            : base(name, year)
        {
            productionVolume = volume;
            Console.WriteLine($"Derived class constructor called for {companyName}");
        }

        ~Factory()
        {
            Console.WriteLine($"Destructor called for {companyName}");
        }

        public new void Show()
        {
            base.Show();
            Console.WriteLine($"Production Volume: {productionVolume}");
        }
    }
}
