using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homework.Generic.Domain.NewFolder
{
    public class Cat : Pet
    {
        public Cat (string name, int age, bool isLazy): base (name, age) 
        {
            Type = "Cat";
            IsLazy = isLazy;

        }
        public bool IsLazy { get; set; }    

        public override string PrintInfo()
        {
            return $"The {Name} is cat and is lazy {IsLazy} ";
        }
    }
}
