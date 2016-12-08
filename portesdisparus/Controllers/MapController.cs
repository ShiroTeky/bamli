using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using PeopLost.Service.Maps;
using PeopLost.Models;
using PeopLost.Core.Domain.Maps;

namespace portesdisparus.Controllers
{
    public class MapController : Controller
    {
        /// <summary>
        /// Display GeoLocation on Maps View 
        /// </summary>
        /// <returns></returns>Not Used
        public ActionResult Index()
        {
            return View();
        }
    }
}
