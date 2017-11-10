using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
    partial class Laboratorium
    {

        public class VeduciLaboratoria
        {
            private string meno, priezvisko;

            public VeduciLaboratoria(string meno, string priezvisko)
            {
                this.meno = meno;
                this.priezvisko = priezvisko;
            }


            public void VypisMeno()
            {
                Console.WriteLine("Meno: {0}\nPriezvisko: {1}", meno, priezvisko);
            }

        }
    }
}
