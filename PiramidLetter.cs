using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class PiramidLetter
    {
        public static void Main6()
        {
            string str;
            Console.WriteLine("Enter the word");
            str = Console.ReadLine();
            for(int row = 0; row < str.Length; row++)
            {
                for(int col = 0; col < row; col++)
                {
                    Console.Write(str[col]);
                }
                Console.WriteLine();
            }
        }
    }
}
