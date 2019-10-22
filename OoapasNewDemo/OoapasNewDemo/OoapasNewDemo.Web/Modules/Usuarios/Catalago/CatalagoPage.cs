
namespace OoapasNewDemo.Usuarios.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.CatalagoRow))]
    public class CatalagoController : Controller
    {
        [Route("Usuarios/Catalago")]
        public ActionResult Index()
        {
            return View("~/Modules/Usuarios/Catalago/CatalagoIndex.cshtml");
        }
    }
}