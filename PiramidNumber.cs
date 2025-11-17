using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class PiramidNumber
    {
        public static void Main5()
        {
            int num;
            Console.WriteLine("Enter the length of the Row:");
            num = Convert.ToInt32(Console.ReadLine());
            num = num + 1;
            for(int row = 0; row < num; row++)
            {
                for(int col = 1; col <= row; col++)
                {
                    Console.Write(col);
                }
                Console.WriteLine();
            }
        }
    }
}
