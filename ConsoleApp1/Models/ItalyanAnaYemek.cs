using CreationalDesignPatterns.AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class ItalyanAnaYemek : IAnaYemek
    {
        public void Hazirla()
        {
            Console.WriteLine("İtalyan ana yemek hazırlanıyor...");
        }
    }
}
