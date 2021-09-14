using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linecompari
{
    class uc2CheckLinesAreEqual
    {
        public static void Main2()
        {
            //first line length
            int X1 = 2;
            int Y1 = 1;  //first co-ordinate point 
            int X2 = 5;
            int Y2 = 4;  //second co-ordinate point

            int M = ((X2 - X1)^2 + (Y2 - Y1)^2);
            Console.WriteLine(Math.Sqrt(M));

            //second line length
            int K1 = 3;
            int J1 = 4;  //first co-ordinate point
            int K2 = 6;
            int J2 = 5;  //second co-ordinate point

            int N = ((K2 - K1)^2 + (J2 - J1)^2);
            Console.WriteLine(Math.Sqrt(N));

            if(Math.Sqrt(M).Equals(Math.Sqrt(N)))
            {
                Console.WriteLine("Length of two lines are equal hence lines are equal .");
            }
            else
            { 
                Console.WriteLine("Length of two lines are not equal hence lines are not equal .");
            }
        }
    }
}