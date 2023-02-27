using Session_10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10 {



    public class Person {
        public enum GenderEnum {
            Male,
            Female,
            Other

        }

        //properties
        public Guid ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public GenderEnum Gender { get; set; }


        //constructors
        public Person() {
            ID = Guid.NewGuid(); 
        }

        public Person(Guid id) {
            ID = id;
        }

        
        //methods
        public void GetName() {

        }

        public void SetName(string name) {

        }


    }
}
