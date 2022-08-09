using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space1
{
    internal class CallByRef
    {
        public void Cube(ref int val1,ref int val2)
        {
            val1 = val1 * val1 * val1;
            val2 = val2 * val2 * val2;
        }
    }
}
