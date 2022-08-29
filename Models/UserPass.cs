using System;
using System.Collections.Generic;

namespace Assignment_6_WebApi.Models
{
    public partial class UserPass
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public float Userid { get; set; }
    }
}
