﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
    partial class Lab1
    {
        //Pristroj LaboratornyPristroj1;
        //Pristroj LaboratornyPristroj2;

        private void SpustVyskum()
        {
            Lab2.VeduciLaboratoria veduci = new Lab2.VeduciLaboratoria("Peter", "Novak");
            veduci.VypisMeno();



        }

    }
}
