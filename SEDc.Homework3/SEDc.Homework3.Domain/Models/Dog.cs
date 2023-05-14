using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDc.Homework3.Domain.Models
{
    public class Dog
    {
        public Dog(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }
        public void Info()
        {
            Console.WriteLine($"Dog {Name}, color {Color} and old {Age} years");
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string  Color { get; set; }  

      

    }
}
