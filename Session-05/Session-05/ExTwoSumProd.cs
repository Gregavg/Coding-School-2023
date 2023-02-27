using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ExTwoSumProd
    {

        private int givenNo;

        public ExTwoSumProd(int input)
        {
            givenNo = input;
        }


        //SUM METHOD
        public long GetSum()
        {

            int sum = 0;

            for (int i = 1; i <= givenNo; i++)
            {
                sum += i;
            }
                return sum;
         }

        //PRODUCT METHOD

        public BigInteger GetProd()
        {

            BigInteger prod = 1;

            for (int i = 1; i <= givenNo; i++)
            {
                prod *= i;
            }
            return prod;
        }



    }
}
