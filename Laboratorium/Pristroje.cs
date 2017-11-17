using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
    sealed class Mikroskop : Pristroj
    {

        public override void VypisDetailneInformacie()
        {
            Console.WriteLine("Typ 1000");
        }

        public new void VypisInformacieOPristroji()
        {
            Pristroj pristroj = new Mikroskop();
            pristroj.VypisInformacieOPristroji();

            Console.WriteLine("Toto je mikroskop.");

            VypisDetailneInformacie();
        }
    }

    sealed class Odstredivka : Pristroj
    {
        public override void VypisDetailneInformacie()
        {
            Console.WriteLine();
        }

        public override void VypisInformacieOPristroji()
        {
            Console.WriteLine("Toto je odstredivka.");
        }
    }
}
