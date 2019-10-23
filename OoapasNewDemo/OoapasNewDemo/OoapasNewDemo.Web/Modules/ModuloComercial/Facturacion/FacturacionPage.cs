using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OoapasNewDemo.ModuloComercial.Pages
{
    public class FacturacionController : Controller
    {
        [Route("ModuloComercial/Facturacion")]
        public IActionResult Index()
        {
            return View("~/Modules/ModuloComercial/Facturacion/FacturacionIndex.cshtml");
        }
    }
}