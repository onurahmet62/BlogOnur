using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Admin.Controllers
{
    public class FotoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
