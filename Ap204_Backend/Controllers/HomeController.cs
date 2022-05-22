using Microsoft.AspNetCore.Mvc;

namespace Ap204_Backend.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index(int id)
        {
            //return Content(id.ToString());
            return View();
        }

        public ActionResult About(int id)
        {
            //return Content(id.ToString());
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult FAQ(string name, string surname)
        {
            string fullname = $"{name} {surname}";

            return Content(fullname);
        }
        

        
    }
}
