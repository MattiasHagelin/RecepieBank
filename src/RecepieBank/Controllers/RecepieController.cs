using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecepieBank.Repositories.Interfaces;
using RecepieBank.ViewModels;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RecepieBank.Controllers
{
    public class RecepieController : Controller
    {
        private IRecepieRepository recepieRepository;

        public RecepieController(IRecepieRepository recepieRepository)
        {
            this.recepieRepository = recepieRepository;
        }

        // GET: /<controller>/
        public IActionResult Recepies()
        {
            return View(recepieRepository.Recepies());
        }

        public IActionResult NewRecepie()
        {
            return View(recepieRepository.NewRecepie());
        }

        [HttpPost]
        public IActionResult NewRecepie(RecepieVM model)
        {
            
            return RedirectToAction(nameof(RecepieController.Recepies));
        }

        public IActionResult Recepie(int id)
        {
            var model = recepieRepository.RecepieById(id);
            return View(model);
        }
    }
}
