using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    public class Company : IUserInterface, IDotNetInterface
    {
        protected string companyName;
        protected int yearFounded;

        public Company(string name, int year)
        {
            companyName = name;
            yearFounded = year;
            Console.WriteLine($"Base class constructor called for {companyName}");
        }

        ~Company()
        {
            Console.WriteLine($"Destructor called for {companyName}");
        }

        public void Show()
        {
            Console.WriteLine($"Company: {companyName}, Year Founded: {yearFounded}");
        }
    }
}
