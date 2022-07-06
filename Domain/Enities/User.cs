using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Enities
{
    public class User : RootEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
