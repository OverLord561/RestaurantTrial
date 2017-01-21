using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantTrial.Models
{
    public class Waiter
    {
        public int WaiterId { get; set; }
        public string WaiterName { get; set; }

        // one Waiter - one Order
        public Order Order { get; set; }
    }
}