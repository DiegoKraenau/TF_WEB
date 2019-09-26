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

        
        [HttpPost]
        public IActionResult detalle(string email)
        {
            ViewBag.Codigo=email;
            return View();
        }
    }
}