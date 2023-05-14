using Newtonsoft.Json;
using SEDc.Homework3.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDc.Homework3
{
    public static  class TextHelper
    {   
      
   
     
         public static List<Dog> Reader(string path)
        {

            using (StreamReader sr = new StreamReader(path))
            {
              return JsonConvert.DeserializeObject<List<Dog>>(sr.ReadToEnd());
            }
            
        }

        public static void Writer(string path, List<Dog> name)
        {

         using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(JsonConvert.SerializeObject(name));
               
            }
        }

     
       
    }
}
