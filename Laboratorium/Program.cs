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
            Laboratorium lab = new Laboratorium();

            Mikroskop mikroskop = new Mikroskop();
            mikroskop.VypisInformacieOPristroji();

        }
    }
}
