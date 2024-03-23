using Lab6CSharp;

class Program
{
    public static void Main(string[] args)
    {
        // Створення об'єктів різних класів і виклик методу Show()
        Organization org = new Organization("Example Org", 2000, 100);
        InsuranceCompany ins = new InsuranceCompany("Insurance Corp", 1995, "Life Insurance", 5000);
        OilGasCompany oil = new OilGasCompany("OilGas Inc", 1978, 10);
        Factory fac = new Factory("Example Factory", 2010, 1000000);

        // Виклик методу Show для кожного об'єкту
        Console.WriteLine("\nShowing details for each object:");
        org.Show();
        ins.Show();
        oil.Show();
        fac.Show();
        Console.WriteLine("\nTask2\n");
        // Створення бази програмного забезпечення
        ISoftware[] softwares = new ISoftware[]
        {
            new FreeSoftware("OpenOffice", "Apache Foundation"),
            new TrialSoftware("Microsoft Office", "Microsoft", DateTime.Parse("2023-01-01"), TimeSpan.FromDays(30)),
            new CommercialSoftware("Adobe Photoshop", "Adobe", 499.99m, DateTime.Parse("2022-12-01"), TimeSpan.FromDays(14), DateTime.Parse("2023-12-01")),
        };

        // Виведення інформації про програмне забезпечення з бази
        Console.WriteLine("Software Base:");
        foreach (var software in softwares)
        {
            software.DisplaySoftwareInfo();
            Console.WriteLine($"Can Use: {software.CanUse(DateTime.Now)}");
            Console.WriteLine();
        }

        // Пошук програмного забезпечення, яке можна використовувати на поточну дату
        Console.WriteLine("Software Available for Current Date:");
        foreach (var software in softwares)
        {
            if (software.CanUse(DateTime.Now))
            {
                software.DisplaySoftwareInfo();
                Console.WriteLine();
            }
        }

        Console.WriteLine("\nTask3\n");

        // Створення бази програмного забезпечення
        SoftwareBase softwareBase = new SoftwareBase();
        softwareBase.AddSoftware(new FreeSoftware("OpenOffice", "Apache Foundation"));
        softwareBase.AddSoftware(new TrialSoftware("Microsoft Office", "Microsoft", DateTime.Parse("2023-01-01"), TimeSpan.FromDays(30)));
        softwareBase.AddSoftware(new CommercialSoftware("Adobe Photoshop", "Adobe", 499.99m, DateTime.Parse("2022-12-01"), TimeSpan.FromDays(14), DateTime.Parse("2023-12-01")));

        // Виведення інформації про програмне забезпечення з бази
        Console.WriteLine("Software Base:");
        foreach (ISoftware software in softwareBase)
        {
            software.DisplaySoftwareInfo();
            Console.WriteLine($"Can Use: {software.CanUse(DateTime.Now)}");
            Console.WriteLine();
        }

        // Пошук програмного забезпечення, яке можна використовувати на поточну дату
        Console.WriteLine("Software Available for Current Date:");
        foreach (ISoftware software in softwareBase)
        {
            if (software.CanUse(DateTime.Now))
            {
                software.DisplaySoftwareInfo();
                Console.WriteLine();
            }
        }
    }
}