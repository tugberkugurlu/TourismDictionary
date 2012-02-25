using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TourismDictionary.Data.DataAccess.Infrastructure;

namespace TourismDictionary.Web.Controllers {

    public class DefaultController : Controller {

        public DefaultController() {

        }

        public ActionResult Index() {

            return View();
        }

    }
}