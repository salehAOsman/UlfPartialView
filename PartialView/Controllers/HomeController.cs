using PartialView.Models;
using System.Linq;
using System.Web.Mvc;

namespace PartialView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult PartIndex()
        {
            return View();
        }

        public ActionResult PartCar(int id)
        {
            //I will look to the list 
            // we use SingleOrDefault it means to avoid null value that come with default value may be
            Car temp = PerCar.Cars.SingleOrDefault(c => c.Id == id);

            return PartialView("_Car",temp);
        }
    }
}