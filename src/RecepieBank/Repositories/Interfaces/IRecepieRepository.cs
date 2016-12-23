using RecepieBank.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecepieBank.Repositories.Interfaces
{
    public interface IRecepieRepository
    {
        RecepieVM[] Recepies();
        RecepieVM RecepieById(int id);
        RecepieVM NewRecepie();
    }
}
