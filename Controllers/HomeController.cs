using Microsoft.AspNetCore.Mvc;
using Tp10.Models;
namespace Tp10.Controllers;

public class HomeController : Controller
{
       public IActionResult Index()
    {
        ViewBag.ListaSeries = BD.CargarSeries();
        return View();
    }

    //tienen que devolver listas no acciones
    // public IActionResult VerDetallesActores(int IdActor){
    //     return BD.VerActores(IdActor);
    // }
    
    // public IActionResult VerDetallesTemporadas(int IdTemporada){
    //     return BD.VerTemporadas(IdTemporada);
    // }
}
