using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public bool Preditor { get; set; }
        public int BeekLength { get; set; }
        public string Color { get; set; }
        public string Song { get; set; }

        public Bird( string name, string color, string song, bool preditor, int beekLength, int legs, int age, string home)
        {
            this.Name = name;
            this.Color = color;
            this.Song = song;
            this.Preditor = preditor;
            this.BeekLength = beekLength;
            this.Legs = legs;
            this.Age = age;
            this.Home = home;
        }
    }
}
