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
    
    public Series VerDetallesSerie(int IdSerie){

        return BD.VerInfoSerie(IdSerie);
    }

    //tienen que devolver listas no acciones
    public List<Actores> VerDetallesActores(int IdSerie){ //hacer un for each para recorrer los actores
        return BD.VerActores(IdSerie);
    }
    
    public List<Temporadas> VerDetallesTemporadas(int IdSerie){
        return BD.VerTemporadas(IdSerie);
    }


}
