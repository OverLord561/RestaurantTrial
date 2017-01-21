using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RestaurantTrial.Models
{
    public class DishFormula
    {
        
        public int DishFormulaId { get; set; }
        public double ComponentWeight { get; set; }

        // one dish - one formula
        public Dish Dish { get; set; }
        // one dish - many Components
        public List<Component> Component { get; set; }
    }
}