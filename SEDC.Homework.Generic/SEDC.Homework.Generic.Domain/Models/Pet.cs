using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homework.Generic.Domain.NewFolder
{
    public abstract class Pet

    {
        public Pet(string name, int age)
        {
            Name = name;
            
            Age = age;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public abstract string PrintInfo();
    }
}
