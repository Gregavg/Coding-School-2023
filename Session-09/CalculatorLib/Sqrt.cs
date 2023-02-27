using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib {
    public class Sqrt : Calculate {
        public override string Do(decimal x, decimal y) {


            double result = 0;
            double z = Convert.ToDouble(y);

            result = Math.Sqrt(z);


            return result.ToString("#.###");
        }

    }
}