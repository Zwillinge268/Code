using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello A = new Hello();
            Hello B = new Hello();
            Hello C = new Hello();

            A.Times("A");
            B.Times("B");
            C.Times("C");

            A.Times("A");
            B.Times("B");
            C.Times("C");

            Console.ReadKey();
        }
    }
}
