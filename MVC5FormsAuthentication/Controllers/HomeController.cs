using System.Web.Mvc;

namespace MVC5FormsAuthentication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Administrator()
        {
            ViewBag.Message = "Admin page.";

            return View();
        }

        [Authorize(Roles = "Admin,Student")]
        public ActionResult Student()
        {
            ViewBag.Message = "Student page.";

            return View();
        }
    }
}