using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ExFourMulti
    {

        //PRIME FINDER
        public int[] GetMulti(int[] inputOne, int[] inputTwo)
        {
            int maxLength = inputOne.Length * inputTwo.Length;
            int[] result = new int[maxLength];

            int counter = 0;

            for (int i = 0; i < inputOne.Length; i++)
            {
                for (int j = 0; j < inputTwo.Length; j++)
                {
                    int a = inputOne[i];
                    int b = inputTwo[j];

                    result[counter] = a * b;
                    counter++;

                }
            }


            return result;
        }








    }
}
