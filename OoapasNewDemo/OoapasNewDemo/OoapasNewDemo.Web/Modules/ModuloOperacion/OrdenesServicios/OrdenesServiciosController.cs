using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ooapas.Web.Modules.ModuloOperacion.OrdenesServicios
{
    public class OrdenesServiciosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}