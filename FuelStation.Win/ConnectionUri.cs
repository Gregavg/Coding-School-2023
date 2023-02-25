using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Win {
    public class ConnectionUri {
        public string MyUri { get; set; } = "https://localhost:7251/";

        public ConnectionUri() {
        }

        public void SetUri(string uri) {
            MyUri = uri;
        }
        public string GetUri() {
            return MyUri;
        }

    }
}
