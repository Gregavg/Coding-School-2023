using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10 {
    public class Course {
        //properties
        public Guid ID { get; set; }
        public Guid Code { get; set; }
        public string? Subject { get; set; }
        

        //constructors
        public Course() {
            ID= Guid.NewGuid();
            Code= Guid.NewGuid();
        }


        //methods

    }
}
