using RecepieBank.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecepieBank.ViewModels
{
    public class NewIngredientInRecepieVM
    {
        public int RecepieId { get; set; }
        public int IngredientId { get; set; }
        public Units Unit { get; set; }
        public float? Quantity { get; set; }
        public ICollection<IngredientVM> Ingredients { get; set; }
    }
}
