using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zooOOP
{
    class Hest
    {
        // hestens navn?
        public String navn;
        //maxhastighed måles i km/t
        public double maxHastighed;
        //fødselsår
        public int year;

        public Hest()
        {
            Console.WriteLine("Indtast venligst hestens navn ");
            navn = Console.ReadLine();
            Console.WriteLine("Hestens fødselsår?");
            year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hvor hurtig er du");
            maxHastighed = Convert.ToDouble(Console.ReadLine());

        }

        private void Eat()
        {
            Console.WriteLine("Gnaske gnaske...");
        }

        public void Run()
        {
            Console.Write("Wrinske wrinske");
            Console.WriteLine(" - med " + maxHastighed + " km/t");
            Console.WriteLine("Wrinske-hilsen " + navn);
            Console.WriteLine("Jeg er " + (2018 - year) + "år gammel");
            Eat();
        }
    }
}