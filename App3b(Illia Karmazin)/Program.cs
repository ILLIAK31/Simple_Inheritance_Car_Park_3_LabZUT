﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3b_Illia_Karmazin_
{
    internal class Program
    {
        static void Test_Drive(ICar obj)
        {
            obj.Refuel();
            obj.Drive();
            obj.Drive();
            obj.Turn_Off();
        }
        static void Main(string[] args)
        {
            var car = new Car_Petrol_Electricity();
            car.Start();
            ((ICar)car).Start();
            ((ICar_Electricity)car).Start();
            //car.Electric_Engine = true;
            ((ICar_Petrol)car).Start();
            Test_Drive(car);
        }
    }
}
