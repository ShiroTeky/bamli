using PeopLost.Service.Comments;
using PeopLost.Web.Models;
using PeopLost.Core.Domain.Comments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PeopLost.Service.Alertes;

namespace portesdisparus.Controllers
{
    public class CommentController : Controller
    {
        ICommentService _commentservice;
        IAlertService _alertservice;

        public CommentController(ICommentService CommentService,IAlertService AlertService)
        {
            _commentservice = CommentService;
            _alertservice = AlertService;
        }

        // GET: Comment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PersonComment()
        {
            var model = new ListCommentViewModel();
            return View(model);
        }

        /// <summary>
        /// GET Partial View
        /// </summary>
        /// <param name="AlertId"></param>
        /// <returns></returns>
        public PartialViewResult _Comment(IList<CommentModels> comments,string AlertId)
        {
            ViewBag.AlertId = AlertId;
            return PartialView(comments);
          
        }

        /// <summary>
        /// GET Partial View
        /// </summary>
        /// <param name="AlertId"></param>
        /// <returns></returns>
        public PartialViewResult _CreateComment(string AlertId)
        {

            ViewBag.AlertId = AlertId;
            return PartialView("_CreateComment");

        }

        
       
     
    }
}