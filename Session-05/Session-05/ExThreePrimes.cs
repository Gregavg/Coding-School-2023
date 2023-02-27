using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ExThreePrimes
    {


        public ExThreePrimes()
        {
           
        }

        //IS PRIME
        public bool IsPrime(int prime)
        {

            bool isPrime = true;

            for (int i = 2; i < prime; i++)
            {
                if (prime % i == 0)
                {
                    isPrime = false;
                }
                
            }
            return isPrime;
        }


        //PRIME FINDER
        public StringBuilder GetPrimes(int input)
        {
            StringBuilder result = new StringBuilder();


            for (int i = 2; i <= input; i++)
            {
                if (IsPrime(i))
                {
                    result.Append(" " + i);
                }
            }


            return result;
        }


















    }
}
