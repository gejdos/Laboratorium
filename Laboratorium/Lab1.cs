﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium
{
    partial class Laboratorium
    {
        Pristroj LaboratornyPristroj1;
        Pristroj LaboratornyPristroj2;

        public void SpustVyskum()
        {
            VypisMeno();

            LaboratornyPristroj1.VypisInformacieOPristroji();
            LaboratornyPristroj2.VypisInformacieOPristroji();

            LaboratornyPristroj1.Zapni();
            LaboratornyPristroj2.Zapni();
        }

    }
}
