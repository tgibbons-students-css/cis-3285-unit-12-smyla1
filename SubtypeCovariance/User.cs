﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ===============================
// AUTHOR     : Sumathilatha Myla
// CREATE DATE     :11/20/2019
// PURPOSE     : User object inherited by base object(Entity).
// ===============================

namespace SubtypeCovariance
{
    public class User : Entity
    {
        public User(Guid newID) : base(newID)
        {
            EmailAddress = "";
        }
        public string EmailAddress { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
