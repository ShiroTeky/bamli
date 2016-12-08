using portesdisparus.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PeopLost.Service.Pictures;

namespace PeopLost.Controllers
{
    public class HomeController : Controller
    {
        private IPictureService _pictureService;
        
        public HomeController(IPictureService PictureService)
        {
           _pictureService = PictureService;
        }

        public ActionResult Index()
        {
            var partialList = _pictureService.GetToAzureStorage();

            return View(partialList);
        }

        
        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}