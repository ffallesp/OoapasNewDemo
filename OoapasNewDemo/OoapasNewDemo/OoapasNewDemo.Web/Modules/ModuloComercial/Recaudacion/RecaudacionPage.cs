using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OoapasNewDemo.ModuloComercial.Pages
{
    public class RecaudacionController : Controller
    {
        [Route("ModuloComercial/Recaudacion")]
        public IActionResult Index()
        {
            return View("~/Modules/ModuloComercial/Recaudacion/RecaudacionIndex.cshtml");
        }
    }
}