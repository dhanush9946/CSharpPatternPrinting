using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class Piramid
    {
        public static void Main2()
        {


            int row, spc, len = 1;
            Console.WriteLine("Enter number of rows:");
            row = Convert.ToInt32(Console.ReadLine());
            spc = row - 1;

            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < spc; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k < len; k++)
                {
                    Console.Write("*");
                }
                spc--;
                len = len + 2;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
