using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Class1
    {
        public int x;
        public int y;
       // public int result;
        public Class1(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.Sum(z);
        }
        public int Sum(int z)
        {
            int result = x + y + z;
            return result;
        }

    }
}
