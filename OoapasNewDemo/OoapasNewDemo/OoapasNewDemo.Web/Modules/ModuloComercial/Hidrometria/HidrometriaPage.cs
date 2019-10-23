using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OoapasNewDemo.ModuloComercial.Pages
{
    public class HidrometriaController : Controller
    {
        [Route("ModuloComercial/Hidrometria")]
        public IActionResult Index()
        {
            return View("~/Modules/ModuloComercial/Hidrometria/HidrometriaIndex.cshtml");
        }
    }
}