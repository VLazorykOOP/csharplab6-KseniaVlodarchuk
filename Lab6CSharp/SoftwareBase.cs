using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    public class SoftwareBase : IEnumerable
    {
        private ArrayList softwareList = new ArrayList();

        // Додавання програмного забезпечення до бази
        public void AddSoftware(ISoftware software)
        {
            softwareList.Add(software);
        }

        // Реалізація методу GetEnumerator() інтерфейсу IEnumerable
        public IEnumerator GetEnumerator()
        {
            return softwareList.GetEnumerator();
        }
    }
}
