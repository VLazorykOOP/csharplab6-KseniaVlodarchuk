using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    public class CommercialSoftware : TrialSoftware
    {
        protected decimal price;
        protected DateTime expiryDate;

        public CommercialSoftware(string name, string manufacturer, decimal price, DateTime installationDate, TimeSpan trialPeriod, DateTime expiryDate)
            : base(name, manufacturer, installationDate, trialPeriod)
        {
            this.price = price;
            this.expiryDate = expiryDate;
        }

        public new void DisplaySoftwareInfo()
        {
            base.DisplaySoftwareInfo();
            Console.WriteLine($"Price: {price}, Expiry Date: {expiryDate}");
        }

        public new bool CanUse(DateTime currentDate)
        {
            // Перевірка, чи не минув строк використання
            return base.CanUse(currentDate) && currentDate <= expiryDate;
        }
    }
}
