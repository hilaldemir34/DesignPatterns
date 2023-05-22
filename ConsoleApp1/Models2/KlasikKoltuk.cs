using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models2
{
    internal class KlasikKoltuk : IKoltuk
    {
        public void BilgiVer()
        { 
            Console.WriteLine("Klasik Koltuk oluştur");
        }
    }
}
