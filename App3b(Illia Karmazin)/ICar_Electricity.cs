﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3b_Illia_Karmazin_
{
    internal interface ICar_Electricity : ICar
    {
        bool Electric_Engine { get; set; }
        bool Battery { get; set; }
        new void Refuel();
        new void Start();
    }
}

