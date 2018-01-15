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
            int a = 6;
            int b = 8;
            int c = 20;
            int d = 30;

            swap(ref c, ref d);
            swap(ref a, ref b);
            swap(ref a, ref c);


            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
        static void swap(ref int a, ref int b)
        {
            int aCopy;
            aCopy = a;
            a = b;
            b = aCopy;
        }
    }
}
