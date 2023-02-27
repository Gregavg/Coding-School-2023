using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_07 {
    internal class ActionConvert : ActionRequest {
        public ActionConvert() { }

        public ActionConvert(string input, ActionEnum action) : base(input, action) {

        }

        public override bool isValid() {
        
            int inputNumber;

            if (Int32.TryParse(Input, out inputNumber)) {
                return true;
            } else {
                return false;
            }
        }

        public override string Convertion() {

            int inputNumber;
            Int32.TryParse(Input, out inputNumber);
            string binary = Convert.ToString(inputNumber, 2);
            return binary;
        }




    }
}
