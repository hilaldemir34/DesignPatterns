using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.AbstractFactory.Models
{
    internal class TurkMutfagiFactory : IYemekFactory
    {
        public ISalata SalataHazirla()
        {
            return new TurkSalata();
        }

        public IAnaYemek YemekHazirla()
        {
            return new TurkAnaYemek();
        }
    }
}
