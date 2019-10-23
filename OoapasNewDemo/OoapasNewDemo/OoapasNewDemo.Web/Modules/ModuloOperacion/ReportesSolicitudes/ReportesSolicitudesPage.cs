using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OoapasNewDemo.ModuloOperacion.Pages
{
    public class ReportesSolicitudesController : Controller
    {
        [Route("ModuloOperacion/ReportesSolicitudes")]
        public IActionResult Index()
        {
            return View("~/Modules/ModuloOperacion/ReportesSolicitudes/ReportesSolicitudesIndex.cshtml");
        }
    }
}