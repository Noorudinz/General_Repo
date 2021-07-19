using System;
using System.Collections.Generic;

#nullable disable

namespace SerAppDataGrid.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public int? Freight { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
