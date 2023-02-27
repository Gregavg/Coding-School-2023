using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib {
    public class Sub : Calculate {
        public override string Do(decimal x, decimal y) {

            decimal result = 0;


            result = x - y;

            return result.ToString("#.###");
        }

    }
}