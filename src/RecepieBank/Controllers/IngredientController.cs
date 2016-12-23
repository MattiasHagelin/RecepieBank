using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecepieBank.ViewModels;
using RecepieBank.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RecepieBank.Controllers
{
    public class IngredientController : Controller
    {
        private IIngredientReopsitory ingredientRepository;

        public IngredientController(IIngredientReopsitory ingredientRepository)
        {
            this.ingredientRepository = ingredientRepository;
        }
        // GET: /<controller>/
        //[Route("ingredient/addIngredient/{recepieId:int}")]
        public IActionResult AddIngredient(List<IngredientInRecepieVM> recepie)
        {
            recepie.Add(new IngredientInRecepieVM());
            return View(recepie);
        }

        //[HttpPost]
        //public IActionResult AddIngredient(RecepieVM model)
        //{
        //    return RedirectToAction(nameof(RecepieController.Recepies), "Recepie");
        //}
    }
}
