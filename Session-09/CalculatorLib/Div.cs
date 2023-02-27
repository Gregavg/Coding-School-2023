using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib {
    public class Div : Calculate {

        public override string Do(decimal x, decimal y) {

            string result;
            if (y == 0) {
                result = "error";
            } else {
                result = (x / y).ToString("#.###");
            }

            return result;
        } 

    }
}
