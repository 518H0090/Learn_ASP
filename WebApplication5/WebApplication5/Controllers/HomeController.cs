using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var obj = new {Id =1,Name ="Trung Hieu" };
            return View(obj);
        }

        public IActionResult About()
        {
            return View();
        }

        public ViewResult Contact()
        {
            return View();
        }

        public ViewResult ExtenView()
        {
            //full path of View Extension
            return View("~/ExtenSpecial/StrangeView.cshtml");
        }

        //Để coi lại

        public ViewResult NewExtenView()
        {
            //relative path
            return View("../../ExtenSpecial/StrangeView");
        }
    }
}
