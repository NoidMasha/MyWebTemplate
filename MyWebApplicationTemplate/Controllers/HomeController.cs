using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApplicationTemplate.Controllers
{
    public partial class HomeController : Infrastructure.BaseController
    {
        // GET: Home
        public virtual ActionResult Index()
        {
            return View();
        }
    }
}