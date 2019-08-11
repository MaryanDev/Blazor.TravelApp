﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TravelApp.Entities.Db
{
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
