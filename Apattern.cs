using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class Apattern
    {
        
        public void Print()
        {
            int row, col, num;
            Console.WriteLine("Enter if you want rows number:");
            num = Convert.ToInt32(Console.ReadLine());

            for (row = 0; row < num; row++)
            {
                for (col = 0; col <= row; col++)
                {
                    Console.Write("A ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public static void Main1()
        {
            Apattern a = new Apattern();
            a.Print();
        }
    }
}
