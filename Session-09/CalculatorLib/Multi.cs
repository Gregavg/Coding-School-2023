using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib {
    public class Multi : Calculate {
        public override string Do(decimal x, decimal y) {

            string result;

            result =(x * y).ToString("#.###");

            return result;
        }

    }
}
