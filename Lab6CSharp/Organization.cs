using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    public class Organization : Company
    {
        protected int numberOfEmployees;

        public Organization(string name, int year, int employees)
            : base(name, year)
        {
            numberOfEmployees = employees;
            Console.WriteLine($"Derived class constructor called for {companyName}");
        }

        ~Organization()
        {
            Console.WriteLine($"Destructor called for {companyName}");
        }

        public new void Show()
        {
            base.Show();
            Console.WriteLine($"Employees: {numberOfEmployees}");
        }
    }
}
