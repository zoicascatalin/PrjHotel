﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facs.Modelli
{
    public class Users
    {
        public Guid ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool CheckedOut { get; set; }
        public int Role { get; set; }
        public DateTime LastLogin { get; set; }
        public int ID_Camera { get; set; }
    }
}
