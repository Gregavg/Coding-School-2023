using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class ActionResponse {
        // PROPERTIES
        public Guid RequestID { get; set; }
        public Guid ResponseID { get; set; }
        public string Output { get; set; }

        // CTOR
        public ActionResponse() {
            ResponseID = Guid.NewGuid();
        }

        public ActionResponse(Guid requestID, string output) {
            ResponseID = Guid.NewGuid();
            RequestID = requestID;
            Output = output;
        }
        public ActionResponse(ActionResponse actionResponse) {
            ResponseID = Guid.NewGuid();
            RequestID = actionResponse.RequestID;
            Output = actionResponse.Output;
        }

        // METHODS




    }
}
