using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
    sealed public class Mikroskop : Pristroj
    {


        public override void VypisInformacieOPristroji()
        {
            Console.WriteLine();

        }
    }

    public abstract class Odstredivka : Pristroj
    {
        public override void VypisInformacieOPristroji()
        {

        }
    }
}
