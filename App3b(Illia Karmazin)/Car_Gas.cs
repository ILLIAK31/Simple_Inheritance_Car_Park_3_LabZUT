using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App3b_Illia_Karmazin_
{
    internal class Car_Gas : ICar , ICar_Gas
    {
        public bool Engine { get; set; } = false;
        public bool Cylinder { get; set; } = false;
        public void Start()
        {
            Console.WriteLine(Engine ? "The car is already started\n" : "Start the car\n");
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
                Console.WriteLine(Cylinder ? "I'm driving on gas \n" : "None gas refuel\n");
                Cylinder = (Cylinder) ? false : true;
            }
            else
                Console.WriteLine("Car is not running\n");
        }
        public void Refuel()
        {
            Console.WriteLine(Cylinder ? "Car already refueled gas\n" : "Refuels gas\n");
            Cylinder = true;
        }
    }
}
