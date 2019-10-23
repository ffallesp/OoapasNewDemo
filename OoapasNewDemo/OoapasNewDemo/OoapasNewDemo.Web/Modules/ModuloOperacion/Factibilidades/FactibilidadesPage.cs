using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OoapasNewDemo.ModuloOperacion.Pages
{
    public class FactibilidadesController : Controller
    {
        [Route("ModuloOperacion/Factibilidades")]
        public IActionResult Index()
        {
            return View("~/Modules/ModuloOperacion/Factibilidades/FactibilidadesIndex.cshtml");
        }
    }
}