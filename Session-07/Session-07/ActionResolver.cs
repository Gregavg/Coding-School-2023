using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class ActionResolver {

        // PROPERTIES
        public MessageLogger? Logger { get; set; }

        // CTOR
        public ActionResolver() {
            Logger= new MessageLogger();
        }

        // METHODS
        public ActionResponse Execute(ActionRequest request) {


            MessageLog("Starting new action...");
            ActionResponse ar;
            if (request.isValid()) {
                ar = new ActionResponse(request.RequestID, request.Convertion());
                MessageLog("Convertion completed!");
                MessageLog(String.Format( "Output for {0} is: {1}", Enum.GetName(request.Action) ,ar.Output));
                return ar;
            } else {
                ar = new ActionResponse();
                MessageLog("Invalid Parameters!");
                return ar;
            }
        }

        private void MessageLog(string text) {

            Logger.Write(new Message("------------"));

            Message message = new Message(text);
            Logger.Write(message); 
        }

    }
}
