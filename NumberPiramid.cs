using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class NumberPiramid
    {
        public static void Main7()
        {
            int row, col, num, temp = 1;
            Console.WriteLine("Howmany row want you?");
            num = Convert.ToInt32(Console.ReadLine());

            for (row = 1; row <= num; row++)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write(temp);
                    temp++;
                }
                Console.WriteLine();
            }
        }
    }
}
