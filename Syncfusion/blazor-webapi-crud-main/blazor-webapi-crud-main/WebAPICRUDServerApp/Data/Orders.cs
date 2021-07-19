using System;
using System.Collections.Generic;

namespace WebAPICRUDServerApp.Data
{
    public partial class Orders
    {
        public long OrderId { get; set; }
        public string CustomerId { get; set; }
        public int? Freight { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
