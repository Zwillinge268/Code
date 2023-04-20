using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_02
{
    class Hello
    {
        public int ABC = 0;
        //static public int ABC = 0;

        public void Times(string which)
        {
            ABC++;
            Console.WriteLine(which + " : " + ABC);
        }
    }
}
