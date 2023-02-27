using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{

    internal class ExOneReverse
    {


        private string inputString;

        public ExOneReverse(string input)
        {
           inputString = input;
        }


        //REVERSE METHOD
        public StringBuilder GetReversed()
        {
            StringBuilder result = new StringBuilder();

            for(int i = inputString.Length-1; i >= 0; i--)
            {
               result.Append(inputString[i]);
            }

            return result;
        }
    }
}
