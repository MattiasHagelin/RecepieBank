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
        public void DeleteRecepieById(int id)
        {
            Context.IngredientsInRecepies.RemoveAll(i => i.RecepieId == id);
            Context.Recepies.RemoveAll(r => r.Id == id);
        }

        public void EditRecepie(RecepieVM recepie)
        {
            var editedRecepie = new Recepie
            {
                Id = recepie.Id,
                Name = recepie.Name,
                Description = Context.ListToCSV(recepie.Description),
                EstimatedTime = recepie.EstimatedTime,
                Ingredients = recepie.Ingredients.Select(i => new IngredientInRecepie
                {
                    Id = Context.IngredientsInRecepies.Single(inr => inr.IngredientId == i.IngredinetId && inr.RecepieId == i.RecepieId).Id,
                    RecepieId = i.RecepieId,
                    IngredientId = i.IngredinetId,
                    Ingredient = Context.Ingredients.Single(ing => ing.Id == i.IngredinetId),
                    Quantity = i.Quantity,
                    Recepie = Context.Recepies.Single(r => r.Id == i.RecepieId),
                    Unit = i.Unit
                }).ToList(),
                OvenTemperature = recepie.OvenTemparature,
                Tags = string.Empty
            };

            Context.Recepies.RemoveAll(r => r.Id == editedRecepie.Id);
            Context.Recepies.Add(editedRecepie);
            throw new NotImplementedException();
        }

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
                        Unit = i.Unit,
                        IngredientName = i.Ingredient.Name
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
