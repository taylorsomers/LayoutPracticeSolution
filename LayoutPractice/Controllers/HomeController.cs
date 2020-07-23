using Microsoft.AspNetCore.Mvc;

namespace LayoutPractice.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}