﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3b_Illia_Karmazin_
{
    internal interface ICar_Petrol
    {
        void Start();
        void Turn_Off();
        void Refuel();
        void Drive();
        bool Engine { get; set; } 
        bool Tank { get; set; }
    }
}