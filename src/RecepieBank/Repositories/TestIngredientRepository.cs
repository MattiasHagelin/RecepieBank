using RecepieBank.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecepieBank.ViewModels;
using RecepieBank.Models;

namespace RecepieBank.Repositories
{
    public class TestIngredientRepository : IIngredientReopsitory
    {
        public void AddIngredient(NewIngredientInRecepieVM model)
        {
            var newIngredientInRecepie = new IngredientInRecepie
            {
                Id = Context.IdGenerator(Context.IngredientsInRecepies),
                Ingredient = Context.Ingredients.Single(i => i.Id == model.IngredientId),
                IngredientId = model.IngredientId,
                Quantity = model.Quantity,
                Recepie = Context.Recepies.Single(r => r.Id == model.RecepieId),
                RecepieId = model.RecepieId,
                Unit = Models.Enums.Units.msk
            };
            Context.IngredientsInRecepies.Add(newIngredientInRecepie);
        }

        public RecepieVM NewIngredientInRecepie(RecepieVM recepie)
        {
            //    var ingredient = new ingredientinrecepievm
            //    {
            //        ingredients = context.ingredients.select(i => new ingredientvm
            //        {
            //            ingredientid = i.id,
            //            name = i.name
            //        })
            //        .tolist()
            //    };
            //    recepie.ingredients.add(ingredient);
            //    return recepie;
                return null;
        }
    }
}
