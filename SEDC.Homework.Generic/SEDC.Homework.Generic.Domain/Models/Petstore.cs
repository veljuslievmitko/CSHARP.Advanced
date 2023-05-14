using SEDC.Homework.Generic.Domain.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homework.Generic.Domain.Models
{
    public class Petstore<T> where T : Pet
    {
        private List<T> _list { get; set; } = new List<T>();
        
        public void PrintPets()
        {
            foreach (T item in _list) 
            {
                Console.WriteLine(item.PrintInfo());
            }
        }
        public void BuyPet(string name)
        {
            T item = _list.FirstOrDefault(x => x.Name == name);
            if (item == null)
            {
                 Console.WriteLine($"There is no pet {item.Type} with that name ");
            }
            _list.Remove(item);
            Console.WriteLine($"{item.Name} was removed from {item.Type} Store");
        }
        public void AddPet(T item)
        {
            _list.Add(item);
        }
        public void AddList(IEnumerable<T> list)
        {
            _list.AddRange(list);
        }

     }
}
