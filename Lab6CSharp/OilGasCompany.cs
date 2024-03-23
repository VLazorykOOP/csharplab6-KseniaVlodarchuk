using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    public class OilGasCompany : Company
    {
        protected int numberOfBranches;
        public OilGasCompany(string name, int year, int branches)
            : base(name, year)
        {
            numberOfBranches = branches;
            Console.WriteLine($"Derived class constructor called for {companyName}");
        }

        ~OilGasCompany()
        {
            Console.WriteLine($"Destructor called for {companyName}");
        }

        public new void Show()
        {
            base.Show();
            Console.WriteLine($"Branches: {numberOfBranches}");
        }
    }

}
