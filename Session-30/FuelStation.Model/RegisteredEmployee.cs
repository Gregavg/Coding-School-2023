﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model {
    public class RegisteredEmployee {

        // Properties
        public string Id { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;


        // Relations
        public string EmployeeId { get; set; } = null!;
        public Employee Employee { get; set; } = null!;

        // Constructor
        public RegisteredEmployee() {
            

        }
    }
}
