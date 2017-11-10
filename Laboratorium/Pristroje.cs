using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
    public abstract class Mikroskop : Pristroj
    {
        public override void VypisInformacieOPristroji()
        {
            
            Console.WriteLine("Hello");


        }
    }

    public abstract class Odstredivka : Pristroj
    {
        public override void VypisInformacieOPristroji()
        {

        }
    }
}
