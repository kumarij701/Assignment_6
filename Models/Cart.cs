using System;
using System.Collections.Generic;

namespace Assignment_6_WebApi.Models
{
    public partial class Cart
    {
        public int CartId { get; set; }
        public string Item { get; set; } = null!;
        public string Category { get; set; } = null!;
        public int Price { get; set; }
        public int? Userid { get; set; }
    }
}
