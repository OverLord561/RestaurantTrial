using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantTrial.Models
{
    public class Component
    {
        public int ComponentId { get; set; }
        public string ComponentName { get; set; }
        // сколько осталось ингредиента на складе
        public double ComponentCount { get; set; }

        // one dish - many Components
        public int DishFormulaId { get; set; }
        public DishFormula DishFormula { get; set; }

    }
}