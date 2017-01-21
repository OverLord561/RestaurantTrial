using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantTrial.Models
{
    public class DishType
    {
        public int DishTypeId { get; set; }
        public string DishTypeName { get; set; }

        // one Type - one dish
        public Dish Dish { get; set; }
    }
}