using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class InterviewTriagle
    {
        public static void Main5()
        {


            string str;
            Console.WriteLine("Enter the string:");
            str = Console.ReadLine();

            for(int row = 0; row < str.Length; row++)
            {
                for(int col = 0; col <= row; col++)
                {
                    Console.Write(str[col]);

                }
                Console.WriteLine();
            }
        }
    }
}
