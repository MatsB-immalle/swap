using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Mats";
            string b = "Dries";

            


            swap(ref a, ref b);

            Console.WriteLine(a);
            Console.WriteLine(b);
            
        }
        static void swap(ref string a, ref string b)
        {
            string x;
            x = a;
            a = b;
            b = x;
            
          
        }
    }
}
