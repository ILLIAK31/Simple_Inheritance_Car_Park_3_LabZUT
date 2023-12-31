﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3b_Illia_Karmazin_
{
    internal class Car_Petrol_Gas : ICar, ICar_Petrol, ICar_Gas
    {
        public bool Engine { get; set; } = false;
        public bool Tank { get; set; } = false;
        public bool Cylinder { get; set; } = false;
        public void Start()
        {
            Console.WriteLine(Engine ? "The car is already started\n" : "Start the car(Engine)\n");
            Engine = true;
        }
        public void Turn_Off()
        {
            Console.WriteLine(Engine ? "Turn off the engine\n" : "Engine is turned off\n");
            Engine = false;
        }
        public void Drive()
        {
            if (Engine)
            {
                if (Tank)
                {
                    Console.WriteLine("I'm driving on petrol \n");
                    Tank = false;
                }
                else if (Cylinder)
                {
                    Console.WriteLine("None petrol refuel\nI'm driving on gas \n");
                    Cylinder = false;
                }
                else
                    Console.WriteLine("None petrol refuel\nNone gas refuel\n");
            }
            else
                Console.WriteLine("Car is not running\n");
        }
        public void Refuel()
        {
            Console.WriteLine(Tank ? "Car already refueled petrol\n" : "Refuels petrol\n");
            Console.WriteLine(Cylinder ? "Car already refueled gas\n" : "Refuels gas\n");
            Tank = Cylinder = true;
        }
        void ICar_Petrol.Refuel()
        {
            Console.WriteLine(Tank ? "Car already refueled petrol\n" : "Refuels petrol\n");
            Tank = true;
        }
        void ICar_Gas.Refuel()
        {
            Console.WriteLine(Cylinder ? "Car already refueled gas\n" : "Refuels gas\n");
            Cylinder = true;
        }
        void ICar_Petrol.Start()
        {
            Console.WriteLine(Engine ? "The car is already started\n" : "Start car(Engine)\n");
            Engine = true;
        }
        void ICar_Gas.Start()
        {
            Console.WriteLine(Engine ? "The car is already started\n" : "Start the car(Engine)\n");
            Engine = true;
        }
    }
}
