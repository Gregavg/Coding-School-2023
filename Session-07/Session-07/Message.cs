using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class Message {
        // PROPERTIES
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string MessageText { get; set; }

        // CTOR
        public Message(string messageText) {
            ID= Guid.NewGuid();
            MessageText = messageText;
            TimeStamp= DateTime.Now;

        }


    }
}
