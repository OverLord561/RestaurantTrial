using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantTrial.Models
{
    public class Dish
    {
        public int DishId { get; set; }
        public string DishName { get; set; }
        public double DishPrice { get; set; }
        public bool IsAvaible { get; set; }
        public string Description { get; set; }
        // наиболее популярна страва
        public int CountOfOrders { get; set; }
       
        // one dish - one type      
        public DishType DishType { get; set; }
        
        //one dish - one formula
        public DishFormula DishFormula { get; set; }

        // one Order - many dishes
        public int OrderId { get; set; }
        public Order Order { get; set; }
      
       
    }
}