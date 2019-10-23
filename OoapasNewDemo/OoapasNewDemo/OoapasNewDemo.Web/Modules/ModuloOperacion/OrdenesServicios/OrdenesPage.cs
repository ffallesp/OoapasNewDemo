using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OoapasNewDemo.ModuloOperacion.Pages
{
    public class OrdenesController : Controller
    {
        [Route("ModuloOperacion/OrdenesServicios")]
        public IActionResult Index()
        {
            return View("~/Modules/ModuloOperacion/OrdenesServicios/OrdenesIndex.cshtml");
        }
    }
}