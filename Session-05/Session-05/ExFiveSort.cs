using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ExFiveSort
    {


        //INSERTION SORT
        public int[] Sort(int[] input)
        {


            for (int i = 1; i < input.Length; i++)
            {
                int j = i;

                while ((j > 0) && (input[j-1] > input[j]))
                {
                    var temp = input[j-1];
                    input[j-1] = input[j];
                    input[j] = temp;
                    j--;
                }
            }

            return input;
        }















        }
}
