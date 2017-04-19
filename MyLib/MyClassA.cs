using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class MyClassA
    {
        public int F(int i)
        {
            return 0;
        }

        public int F(ref int i)
        {
            i = 99;
            return 0;
        }

        //public int F(out int i)
        //{
        //    i = 88;
        //    return 0;
        //}
    }
}
