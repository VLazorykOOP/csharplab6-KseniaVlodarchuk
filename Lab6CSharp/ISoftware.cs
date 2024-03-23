using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    public interface ISoftware
    {
        void DisplaySoftwareInfo();
        bool CanUse(DateTime currentDate);
    }
}
