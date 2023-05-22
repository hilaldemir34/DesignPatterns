using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models2
{
    internal interface IMobilyaFactory
    {
        IKoltuk KoltukOlustur();
        IMasa MasaOlustur();
    }
}
