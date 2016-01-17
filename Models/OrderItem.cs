﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marjani.Peyment.Bitcoin.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public double Total { get; set; }
        public bool IsPayed { get; set; }
        public DateTime CreatOn { get; set; }
        public string Address { get; set; }
        public string confirmations { get; set; }
        public string Value { get; set; }

        public DateTime? PayOn { get; set; }
    }
}