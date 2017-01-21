using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantTrial.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderTime { get; set; }
        public double OrderPrice { get; set; }
        // пожелание на день
        public string Wish { get; set; }
        // количество страв
        public int CountOfDishes { get; set; }

        // one Order - one Waiter       
        public Waiter Waiter { get; set; }

        // one Order - many dishes
        public List<Dish> Dish { get; set; }
    }
}