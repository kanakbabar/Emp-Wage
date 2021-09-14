using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    class uc3CheckWhichLineAreGreater
    {
        public static void Main3()
        {
            //first line length
            int X1 = 2;
            int Y1 = 1;  //first co-ordinate point 
            int X2 = 5;
            int Y2 = 4;  //second co-ordinate point

            int M = ((X2 - X1) ^ 2 + (Y2 - Y1) ^ 2);
            Console.WriteLine(Math.Sqrt(M));

            //second line length
            int K1 = 3;
            int J1 = 4;  //first co-ordinate point
            int K2 = 6;
            int J2 = 5;  //second co-ordinate point

            int N = ((K2 - K1)^2 + (J2 - J1)^2);
            Console.WriteLine(Math.Sqrt(N));

            if (Math.Sqrt(M) >= ((Math.Sqrt(N))))
            {
                Console.WriteLine("first line is greater than second line .");
            }
            else
            {
                Console.WriteLine("second line is greater than first line .");
            }
                   
        }
    }
}