using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.siniflar;

namespace WebApplication1.Controllers
{
    public class APIController : Controller
    {

        Context c = new Context();
        // GET: API
        public ActionResult Index()
        {
            var t = c.Nedir.ToList();
            return View(t);
        }

        public ActionResult nedir()
        {
            var t  = c.Nedir.ToList();
            return View(t);
        }
    }
}