using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    public class TrialSoftware : FreeSoftware
    {
        protected DateTime installationDate;
        protected TimeSpan trialPeriod;

        public TrialSoftware(string name, string manufacturer, DateTime installationDate, TimeSpan trialPeriod)
            : base(name, manufacturer)
        {
            this.installationDate = installationDate;
            this.trialPeriod = trialPeriod;
        }

        public new void DisplaySoftwareInfo()
        {
            base.DisplaySoftwareInfo();
            Console.WriteLine($"Installation Date: {installationDate}, Trial Period: {trialPeriod.TotalDays} days");
        }

        public new bool CanUse(DateTime currentDate)
        {
            // Перевірка, чи не минув строк безкоштовного використання
            return currentDate <= installationDate + trialPeriod;
        }
    }
}
