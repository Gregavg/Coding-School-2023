using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class ActionRequest {

        // PROPERTIES
        public Guid RequestID { get; set; }
        public string? Input { get; set; }
        public ActionEnum Action { get; set; }

        // CTOR
        public ActionRequest() {
            RequestID = Guid.NewGuid();
        }

        public ActionRequest(string input, ActionEnum action) {
            RequestID = Guid.NewGuid();
            Input = input;
            Action = action;

        }


        // METHODS
        public virtual bool isValid() {

            return false;
        }

        public virtual string Convertion() {
            return null;
        }
        

    }





}




