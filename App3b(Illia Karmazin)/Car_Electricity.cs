using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3b_Illia_Karmazin_
{
    internal class Car_Electricity : ICar , ICar_Electricity
    {
        public bool Electric_Engine { get; set; } = false;
        public bool Battery { get; set; } = false;
        public void Start()
        {
            Console.WriteLine(Electric_Engine ? "The car is already started\n" : "Start the car\n");
            Electric_Engine = true;
        }
        public void Turn_Off()
        {
            Console.WriteLine(Electric_Engine ? "Turn off the engine\n" : "Engine is turned off\n");
            Electric_Engine = false;
        }
        public void Drive()
        {
            if (Electric_Engine)
            {
                Console.WriteLine(Battery ? "I'm driving on electricity \n" : "None electricity refuel\n");
                Battery = (Battery) ? false : true;
            }
            else
                Console.WriteLine("Car is not running\n");
        }
        public void Refuel()
        {
            Console.WriteLine(Battery ? "Car already refueled electricity\n" : "Refuels electricity\n");
            Battery = true;
        }
    }
}
