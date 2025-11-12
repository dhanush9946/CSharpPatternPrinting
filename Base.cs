using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
     class Base
    {
        public static void Main4()
        {
            int col,row,num = 5;
             

            for(row = 0;row<num; row++)
            {
                for (col = 0; col <= row; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
