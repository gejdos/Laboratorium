using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
    abstract class Pristroj
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

        }

        public void Vypni()
        {

        }

    }
}
