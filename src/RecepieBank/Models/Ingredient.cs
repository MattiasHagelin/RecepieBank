using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecepieBank.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<IngredientInRecepie> Recepies { get; set; }
    }
}
