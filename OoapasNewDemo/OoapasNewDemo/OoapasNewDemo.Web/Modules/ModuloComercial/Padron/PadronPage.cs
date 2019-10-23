namespace OoapasNewDemo.ModuloComercial.Pages {
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    public class PadronController : Controller {
        [Route("ModuloComercial/Padron")]
        public ActionResult Index() {
            return View("~/Modules/ModuloComercial/Padron/PadronIndex.cshtml");
        }
    }
}
