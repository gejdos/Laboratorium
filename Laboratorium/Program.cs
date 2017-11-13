using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
    class Program
    {
        static void Main(string[] args)
        {
            Laboratorium Lab = new Laboratorium();

            Pristroj LaboratornyPristroj1 = new Mikroskop();
            Pristroj LaboratornyPristroj2 = new Odstredivka();

            Laboratorium.VeduciLaboratoria veduci = new Laboratorium.VeduciLaboratoria("Peter", "Novak");

            Lab.SpustVyskum();



        }
    }
}
