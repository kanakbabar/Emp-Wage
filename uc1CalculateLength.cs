using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    class uc1CalculateLength
    {
        public static void Main1()
        {
            //Enter co-ordinates of first point 
            int pointX1 = 2;
            int pointY1 = 3;

            //Enter co-ordinates of second point 
            int pointX2 = 6;
            int pointY2 = 4;

            int z = ((pointX2 - pointX1)^2 + (pointY2 - pointY1)^2);
            {
                Console.WriteLine(Math.Sqrt(z));
            }
        } 
    }
}
