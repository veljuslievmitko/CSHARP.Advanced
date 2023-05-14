using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homework.Generic.Domain.NewFolder
{
    public  class Fish : Pet
    {
     

        public Fish(string name, int age, string color, int size) : base (name, age)
        {
            Color = color;
            Size = size;
            Type = "Fish";
        }
        public string Color { get; set; }
        public int Size { get; set; }

        public override string PrintInfo()
        {
            return $"The Fish {Name} - Color {Color} and {Size}";
        }
    }
}
