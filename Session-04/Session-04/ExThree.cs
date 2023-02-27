using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class ExThree
    {    
        //FIRST CALCULATION
        public int firstCalc()
        {

            int x = -1;
            int y = 5;
            int z = 6;

            int result = x + (y * z);

            return result;
        }

        //SECOND CALCULATION
        public int secondCalc()
        {

            int x = 38;
            int y = 5;
            int z = 7; 


            // ASSUMMING THE EQUATION IS: a + (b mod c) and NOT (a + b) mod c 
            int result = x + (y % z);

            return result;
        }

        //THIRD CALCULATION
        public double thirdCalc()
        {
            float x = 14;
            float y = -3;
            float z = 6;
            float q = 7; 


            double result = x + (( y *  z) /  q);
            

            return result;
        }

        //FOURTH CALCULATION
        public double fourthCalc()
        {

            float x = 2;
            float y = 13;
            float z = 6;
            float q = 6;
            double v = Math.Sqrt(7);
            


            double result = x + ((y/z) * q) + v;

            return result;
        }

        //FIFTH CALCULATION
        public double fifthCalc()
        {

            double x = Math.Pow(6, 4);
            double y = Math.Pow(5, 7);
            float z = 9;
            float q = 4;

            double result = (x + y) / (z % q);

            return result;
        }














    }






}
