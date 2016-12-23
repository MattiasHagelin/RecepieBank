using RecepieBank.Models;
using RecepieBank.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecepieBank.Repositories
{
    public class Context
    {
        public static List<Recepie> Recepies { get; private set; }
        public static List<Ingredient> Ingredients { get; private set; }
        public static List<IngredientInRecepie> IngredientsInRecepies { get; set; }

        static Context()
        {
            Recepies = new List<Recepie>();
            Ingredients = new List<Ingredient>();
            IngredientsInRecepies = new List<IngredientInRecepie>();

            #region
            Ingredients.Add(new Ingredient
            {
                Id = IdGenerator(Ingredients),
                Name = "Mjölk"
            });

            Ingredients.Add(new Ingredient
            {
                Id = IdGenerator(Ingredients),
                Name = "Vetemjöl"
            });

            Ingredients.Add(new Ingredient
            {
                Id = IdGenerator(Ingredients),
                Name = "Ägg"
            });
            
            Ingredients.Add(new Ingredient
            {
                Id = IdGenerator(Ingredients),
                Name = "Smör"
            });

            Ingredients.Add(new Ingredient
            {
                Id = IdGenerator(Ingredients),
                Name = "Salt"
            });
            #endregion

            #region Recepies
            Recepies.Add(new Recepie
            {
                Id = IdGenerator(Recepies),
                Name = "Pannkaka",
                EstimatedTime = "A long time",
                OvenTemperature = null,
                Description = "Blanda ingredienserna;Stek;Ät"
            });

            Recepies.Add(new Recepie
            {
                Id = IdGenerator(Recepies),
                Name = "TestRecepie2"
            });
            #endregion

            #region IngredinetInRecepie
            IngredientsInRecepies.Add(new IngredientInRecepie
            {
                Id = IdGenerator(IngredientsInRecepies),
                IngredientId = 0,
                Ingredient = Ingredients.Single(i => i.Id == 0),
                Quantity = 6f,
                RecepieId = 0,
                Recepie = Recepies.Single(r => r.Id == 0),
                Unit = Units.dl
            });
            IngredientsInRecepies.Add(new IngredientInRecepie
            {
                Id = IdGenerator(IngredientsInRecepies),
                IngredientId = 1,
                Ingredient = Ingredients.Single(i => i.Id == 1),
                Quantity = 2.5f,
                RecepieId = 0,
                Recepie = Recepies.Single(r => r.Id == 0),
                Unit = Units.dl
            });
            IngredientsInRecepies.Add(new IngredientInRecepie
            {
                Id = IdGenerator(IngredientsInRecepies),
                IngredientId = 2,
                Ingredient = Ingredients.Single(i => i.Id == 2),
                Quantity = 3,
                RecepieId = 0,
                Recepie = Recepies.Single(r => r.Id == 0),
                Unit = Units.st
            });
            IngredientsInRecepies.Add(new IngredientInRecepie
            {
                Id = IdGenerator(IngredientsInRecepies),
                IngredientId = 3,
                Ingredient = Ingredients.Single(i => i.Id == 3),
                Quantity = 2,
                RecepieId = 0,
                Recepie = Recepies.Single(r => r.Id == 0),
                Unit = Units.msk
            });
            IngredientsInRecepies.Add(new IngredientInRecepie
            {
                Id = IdGenerator(IngredientsInRecepies),
                IngredientId = 4,
                Ingredient = Ingredients.Single(i => i.Id == 4),
                Quantity = 0.5f,
                RecepieId = 0,
                Recepie = Recepies.Single(r => r.Id == 0),
                Unit = Units.tsk
            });
            #endregion

            Recepies.Single(r => r.Id == 0).Ingredients = IngredientsInRecepies.Where(i => i.RecepieId == 0).ToList();
        }

        public static int IdGenerator<T>(List<T> list)
        {
            return list.Count;
        }
    }
}
