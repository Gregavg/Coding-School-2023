using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class ExTwo
    {

        int x = 36;
        int y = 6;

        //Get Number x
        public int getX()
        {

            return x;
        }
        //Get Number y
        public int getY()
        {

            return y;
        }

        //SUM
        public int getSum()
        {
            
            int result = x + y;

            return result;
        }

        //DIVISION
        public double getDivision()
        {
                double result = (double)x / (double)y;

                return result;
            
        }


    }
}
