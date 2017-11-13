using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
    abstract class Pristroj : IOvladaniePristroja
    {
        private bool zapnute;
        private int cisloPristroja;

        public virtual void VypisInformacieOPristroji()
        {
            cisloPristroja = 1;
            Console.WriteLine("Cislo pristroja je {0}", cisloPristroja);
        }

        public abstract void VypisDetailneInformacie();

        public void Zapni()
        {
            zapnute = true;
            Console.WriteLine("Pristroj je zapnuty.");
        }

        public void Vypni()
        {
            zapnute = false;
            Console.WriteLine("Pristroj je vypnuty.");
        }

    }
}
