using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public string Color { get; set; }
        public string EnergyLevel { get; set; }
        public string BloodType { get; set; }
        public string Food { get; set; }


        public Reptile(string name , string color, string energy, string blood, string food, int legs, int age, string  home )
        {
            this.Name = name;
            this.Color = color;
            this.EnergyLevel = energy;
            this.BloodType = blood;
            this.Food = food;
            this.Legs = legs;
            this.Age = age;
            this.Home = home;
        }
    }
}
