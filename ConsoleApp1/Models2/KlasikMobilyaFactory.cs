using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models2
{
    internal class KlasikMobilyaFactory : IMobilyaFactory
    {
        public IKoltuk KoltukOlustur()
        {
            return new KlasikKoltuk();
        }

        public IMasa MasaOlustur()
        {
            return new KlasikMasa();
        }
    }
}
