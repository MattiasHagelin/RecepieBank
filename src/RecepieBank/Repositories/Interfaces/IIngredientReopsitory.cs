using RecepieBank.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecepieBank.Repositories.Interfaces
{
    public interface IIngredientReopsitory
    {
        RecepieVM NewIngredientInRecepie(RecepieVM recepie);
        void AddIngredient(NewIngredientInRecepieVM model);
    }
}
