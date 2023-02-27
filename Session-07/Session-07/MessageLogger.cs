using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class MessageLogger {
        // PROPERTIES
        Message[] Messages { get; set; }
        private int _index = 0;

        // CTOR
        public MessageLogger() {
            Messages = new Message[1000];

        }


        //methods
        public void ReadAll() {
            if (_index > 0) {
                for (int i = 0; i < _index; i++) {
                    Console.WriteLine(Messages[i].MessageText);
                }

            }else {
                Console.WriteLine("No messages found!"); 
            }


        }

        public void Clear() {
            if (_index > 0) {
                Array.Clear(Messages, 0, _index - 1);
                _index = 0;
            }
        }

        public void Write(Message message) {

            Messages[_index] = message;
            _index++;

        }

    }
}
