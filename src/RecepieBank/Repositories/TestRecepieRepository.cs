using RecepieBank.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecepieBank.ViewModels;
using RecepieBank.Models;

namespace RecepieBank.Repositories
{
    public class TestRecepieRepository : IRecepieRepository
    {
        public RecepieVM NewRecepie()
        {
            return new RecepieVM
            {
                Description = new List<string>(),
                Ingredients = new List<IngredientInRecepieVM>(),
            };
        }

        public RecepieVM RecepieById(int id)
        {
            return Context.Recepies.Where(r => r.Id == id)
                .Select(r => new RecepieVM
                {
                    Id = r.Id,
                    Name = r.Name,
                    EstimatedTime = r.EstimatedTime,
                    Ingredients = r.Ingredients.Select(i => new IngredientInRecepieVM
                    {
                        Quantity = i.Quantity,
                        Unit = i.Unit
                    })
                    .ToList(),
                    OvenTemparature = r.OvenTemperature,
                    Description = r.Description.Split(';').ToList()
                })
                .Single();
        }

        public RecepieVM[] Recepies()
        {
            return Context.Recepies.Select(r => new RecepieVM
            {
                Id = r.Id,
                Name = r.Name
            })
            .ToArray();
        }
    }
}
