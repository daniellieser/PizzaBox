﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PizzaBoxData
{
    public partial class Order
    {
        public DateTime? TimeReceived { get; set; }
        public decimal? Total { get; set; }
        public string Summary { get; set; }
        public int OrderId { get; set; }
        public int? UserId { get; set; }
        public int? StoreId { get; set; }

        public virtual Store Store { get; set; }
        public virtual User User { get; set; }
    }
}
