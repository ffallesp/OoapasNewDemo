using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OoapasNewDemo.ModuloComercial.Pages
{
    public class GestionController : Controller
    {
        [Route("ModuloComercial/GestionCobranza")]
        public IActionResult Index()
        {
            return View("~/Modules/ModuloComercial/GestionCobranza/GestionIndex.cshtml");
        }
    }
}