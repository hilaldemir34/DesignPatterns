using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.AbstractFactory.Models
{
    internal interface IYemekFactory
    {
        public IAnaYemek YemekHazirla();
        public ISalata SalataHazirla();
    }
}
