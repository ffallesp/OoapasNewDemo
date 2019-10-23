using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OoapasNewDemo.ModuloComercial.Pages
{
    public class ContratosController : Controller
    {
        [Route("ModuloComercial/Contratos")]
        public IActionResult Index()
        {
            return View("~/Modules/ModuloComercial/Contratos/ContratosIndex.cshtml");
        }
    }
}