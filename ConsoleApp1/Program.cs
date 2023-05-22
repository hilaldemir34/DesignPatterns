using ConsoleApp1.Models2;
using CreationalDesignPatterns.AbstractFactory.Models;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IYemekFactory factory = new TurkMutfagiFactory();
            //IAnaYemek yemek = factory.YemekHazirla();
            //yemek.Hazirla();

            //ISalata salata = factory.SalataHazirla();
            //salata.Hazirla();
            IMobilyaFactory factory = new KlasikMobilyaFactory();
            IKoltuk koltuk = factory.KoltukOlustur();
            koltuk.BilgiVer();

            Console.ReadLine();
        }
    }
}
