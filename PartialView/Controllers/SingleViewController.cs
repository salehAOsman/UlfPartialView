using PartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialView.Controllers
{
    public class SingleViewController : Controller
    {
        // GET: SingleView Ajax and Json create view 
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult AjaxRemoveCar(int id)
        {
            PerCar.Cars.Remove(PerCar.Cars.SingleOrDefault(c => c.Id == id));

            return Content("");//this type of remove then we return empty result instead because we delete object
        }
    }
}