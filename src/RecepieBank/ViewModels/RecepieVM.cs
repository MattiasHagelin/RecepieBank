using RecepieBank.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecepieBank.ViewModels
{
    public class RecepieVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EstimatedTime { get; set; }
        public int? OvenTemparature { get; set; }
        public ICollection<IngredientInRecepieVM> Ingredients { get; set; }
        public ICollection<string> Description{ get; set; }
    }
}
