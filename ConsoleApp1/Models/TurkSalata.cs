using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.AbstractFactory.Models
{
    internal class TurkSalata : ISalata
    {
        public void Hazirla()
        {
            Console.WriteLine("Türk Salatası hazırla");
        }
    }
}
