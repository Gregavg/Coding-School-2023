using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib {
    public class Power : Calculate {
        public override string Do(decimal x, decimal y) {

            double result = 0;

            result = Math.Pow((double)x,(double) y);

            return result.ToString("#.###");
        }

    }
}
