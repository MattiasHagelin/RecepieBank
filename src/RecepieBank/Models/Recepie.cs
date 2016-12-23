using RecepieBank.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecepieBank.ViewModels;

namespace RecepieBank.Models
{
    public class Recepie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EstimatedTime { get; set; }
        public int? OvenTemperature { get; set; }
        public ICollection<IngredientInRecepie> Ingredients { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
    }
}
