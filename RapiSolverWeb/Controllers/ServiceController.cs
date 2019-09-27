using System.Linq;
using Hospital.Repositoy.dbcontext;
using Microsoft.AspNetCore.Mvc;
using RapiSolverWeb.Models.Service;

namespace RapiSolverWeb.Controllers
{
    public class ServiceController : Controller
    {
        ApplicationDbContext contexto;

        public ServiceController(ApplicationDbContext _contexto){
            contexto=_contexto;
        }
       

        [HttpGet]
        public IActionResult list()
        {

           ViewBag.Servicios=contexto.servicio.ToList();
           
        
            return View();
        }

        
        [HttpGet]
        public IActionResult detalle()
        {
           // ViewBag.Codigo=email;
            return View();
        }

        [HttpGet]
        public IActionResult agregar()
        {
           // ViewBag.Codigo=email;
            return View();
        }
    }
}