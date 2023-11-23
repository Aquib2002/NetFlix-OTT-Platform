using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetFlix.Controllers
{
    public class BaseController : Controller
    {
        public string GetCurrentUserName()
        {
            return ("Admin");
        }
    }
}