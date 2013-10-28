using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VerticalTabsExample.Models;

namespace VerticalTabsExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<VerticalTabModel> model = new List<VerticalTabModel>();

            //Left side
            model.Add(new VerticalTabModel("about", Alignment.Left, "100px", "http://supperslonic.com"));

            //Right side
            model.Add(new VerticalTabModel("shop", Alignment.Right, "100px"));
            model.Add(new VerticalTabModel("news", Alignment.Right, "201px"));
            model.Add(new VerticalTabModel("search", Alignment.Right, "302px"));

            return View(model);
        }
    }
}
