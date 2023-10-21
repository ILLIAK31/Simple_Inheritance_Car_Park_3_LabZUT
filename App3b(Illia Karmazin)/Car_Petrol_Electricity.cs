using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3b_Illia_Karmazin_
{
    internal class Car_Petrol_Electricity : ICar , ICar_Petrol , ICar_Electricity
    {
        public bool Engine { get; set; } = false;
        public bool Electric_Engine { get; set; } = false;
        public bool Tank { get; set; } = false;
        public bool Battery { get; set; } = false;
        public void Start()
        {
            Console.WriteLine(Engine || Electric_Engine ? "The car is already started\n" : "Start the car\n");
            Engine = Electric_Engine = true;
        }
        public void Turn_Off()
        {
            Console.WriteLine(Engine || Electric_Engine ? "Turn off the engine\n" : "Engine is turned off\n");
            Engine = Electric_Engine = false;
        }
        public void Drive()
        {
            if (Engine)
            {
                if (Tank)
                {
                    Console.WriteLine("I'm driving on petrol \n");
                    Tank = !Tank;
                }
                else if (Battery)
                {
                    Console.WriteLine("None petrol refuel\nI'm driving on electricity \n");
                    Battery = false;
                }
                else
                    Console.WriteLine("None petrol refuel\nNone electricity refuel\n");
            }
            else
                Console.WriteLine("Car is not running\n");
        }
        public void Refuel()
        {
            Console.WriteLine(Tank ? "Car already refueled petrol\n" : "Refuels petrol\n");
            Tank = true;
            Console.WriteLine(Tank ? "Car already refueled electricity\n" : "Refuels electricity\n");
            Battery = true;
        }
    }
}
