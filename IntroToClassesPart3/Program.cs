using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToClassesPart3
{
    class Program
    {
        static void Main(string[] args)
        {
            Method method = new Method();
            // trigger first method with int
            int N = 97;
            Console.WriteLine( method.Add10( N ) );
            // trigger second method with decimal param
            decimal N_dec = Convert.ToDecimal( N );
            Console.WriteLine( method.Add10( N_dec ) );
            // trigger third method with string param
            string str = "97a";
            int str_int = method.Add10( str );
            Console.WriteLine( str_int );
        }
    }
}
