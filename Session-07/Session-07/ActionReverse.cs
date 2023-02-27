using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class ActionReverse : ActionRequest{

        //properties

        //CONSTRUCTORS
        public ActionReverse(string input, ActionEnum action) : base(input, action) {

        }
        //METHODS


        public override bool isValid() {

            if (Input is string)
                return true;
            else return false;
        }

        public override string Convertion() {


            char[] chars = Input.ToCharArray();
            Array.Reverse(chars);
            return new String(chars);
        }


    }
}
