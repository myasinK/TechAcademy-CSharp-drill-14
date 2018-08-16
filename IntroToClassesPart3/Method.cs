using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToClassesPart3
{
    public class Method
    {
        public int Add10(int num)
        {
            return num + 10;
        }
        public int Add10(decimal num)
        {
            return (int)num / 10; 
        }
        public int Add10(string str)
        {
            try
            {
                int str_try = Convert.ToInt32( str );
                return str_try + 10;
            }
            catch
            {
                Console.WriteLine("Error: Conversion not possible");
                return 0;
            }
            
        }
    }
}
