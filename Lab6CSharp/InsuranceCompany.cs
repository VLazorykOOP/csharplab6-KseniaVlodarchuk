using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    public class InsuranceCompany : Company
    {
        protected string insuranceType;
        protected int numberOfClients;

        public InsuranceCompany(string name, int year, string type, int clients)
            : base(name, year)
        {
            insuranceType = type;
            numberOfClients = clients;
            Console.WriteLine($"Derived class constructor called for {companyName}");
        }

        ~InsuranceCompany()
        {
            Console.WriteLine($"Destructor called for {companyName}");
        }

        public new void Show()
        {
            base.Show();
            Console.WriteLine($"Insurance Type: {insuranceType}, Clients: {numberOfClients}");
        }
    }
}
