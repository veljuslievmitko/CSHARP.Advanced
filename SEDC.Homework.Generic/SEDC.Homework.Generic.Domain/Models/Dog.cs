using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homework.Generic.Domain.NewFolder
{
    public class Dog : Pet
    {   
        public Dog(string name, int age, string favoriteFood) : base(name, age)
        {
            Type = "Dog";
            FavoriteFood = favoriteFood;
        }
        public string FavoriteFood { get; set; }

          
        public override string PrintInfo()
        {
            return $"The dog {Name} is years {Age} old and has favorite food{FavoriteFood}";
        }
    }
}
