using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homework2
{
    public static class TextHelper
    {
        public static void CheckIfNumber(string text)
        {
            bool ifParsed = int.TryParse(text, out int value);
            if (ifParsed)
            {
                
            }
        }
    }
}
