using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OoapasNewDemo.ModuloComercial.Pages
{
    public class ServiciosController : Controller
    {
        [Route("ModuloComercial/Servicios")]
        public IActionResult Index()
        {
            return View("~/Modules/ModuloComercial/Servicios/ServiciosIndex.cshtml");
        }
    }
}