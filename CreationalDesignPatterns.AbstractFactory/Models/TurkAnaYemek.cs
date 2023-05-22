using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.AbstractFactory.Models
{
    internal class TurkAnaYemek : IAnaYemek
    {
        public void Hazirla()
        {
            Console.WriteLine("Türk ana yemeği hazırlanıyor");
        }
    }
}
