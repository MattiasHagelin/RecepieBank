using RecepieBank.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecepieBank.Models
{
    public class IngredientInRecepie
    {
        public int Id { get; set; }
        public float? Quantity { get; set; }
        public Units Unit { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        public int RecepieId { get; set; }
        public Recepie Recepie { get; set; }
    }
}
