using Session_10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_10 {
    public class Institute {
        //properties
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int YearsInService { get; set; }

        //constructors
        public Institute() {
            ID = Guid.NewGuid();
        }

        public Institute(Guid id) {
            ID = id;
        }

        public Institute(Guid id, string name) {
            ID = id;
            Name = name;
        }

        public Institute(Guid id, string name, int yearsInService) {
            ID = id;
            Name = name;
            YearsInService = yearsInService;
        }

        //methods
        public void GetName() {

        }

        public void SetName(string name) {

        }
    }
}

