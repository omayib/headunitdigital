using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace headunitdigital
{
    interface EventListener
    {
        void updateDisplay(String speed,String rpm, String fuel);
    }
}
