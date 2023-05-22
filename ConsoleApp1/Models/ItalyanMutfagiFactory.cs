using CreationalDesignPatterns.AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class ItalyanMutfagiFactory : IYemekFactory
    {
        public ISalata SalataHazirla()
        {
            return new ItalyanSalata();
        }

        public IAnaYemek YemekHazirla()
        {
            return new ItalyanAnaYemek();
        }
    }
}
