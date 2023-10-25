using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3b_Illia_Karmazin_
{
    internal class Car_Petrol : ICar, ICar_Petrol
    {
        public bool Engine { get; set; } = false;
        public bool Tank { get; set; } = false;
        public void Start()
        {
            Console.WriteLine(Engine ? "The car is already started\n" : "Start car(Engine)\n");
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
                Console.WriteLine(Tank ? "I'm driving on petrol \n" : "None petrol refuel\n");
                Tank = false;
            }
            else
                Console.WriteLine("Car is not running\n");
        }
        public void Refuel()
        {
            Console.WriteLine(Tank ? "Car already refueled petrol\n" : "Refuels petrol\n");
            Tank = true;
        }
    }
}