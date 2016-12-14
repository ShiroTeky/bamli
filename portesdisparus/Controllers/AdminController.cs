using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PeopLost.Service.Alertes;
using PeopLost.Service.Persons;
using PeopLost.Service.Maps;
using PeopLost.Service.Comments;
using PeopLost.Core.Domain.Persons;
using PeopLost.Core.Domain.Alertes;
using PeopLost.Core.Domain.Comments;
using PeopLost.Core.Domain.Maps;
using PeopLost.Service.Pictures;
using PeopLost.Web.Models;
using PeopLost.Dapper;
using PeopLost.Service.Members;
using PeopLost.Core.Domain.Members;

namespace PeopLost.Controllers
{
    public class AdminController : Controller
    {
        private IAlertService _alertservice;
        private IPersonService _personservice;
        private ICommentService _commentservice;
        private IPersonPointGeoService _pointservice;
        private IPictureService _pictureservice;
        private IMemberService _memberservice;

        public AdminController(IAlertService Alertservice, IPersonService PersonService,
            ICommentService CommentService,
            IPersonPointGeoService PointService, IPictureService PictureService, IMemberService MemberService)
        {
            _alertservice = Alertservice;
            _personservice = PersonService;
            _commentservice = CommentService;
            _pointservice = PointService;
            _pictureservice = PictureService;
            _memberservice = MemberService;
        }

        //List of All Alerts
        public ActionResult Alerts(string personname)
        {
            var items = _alertservice.GetAllAlertsPersons();
            if(!String.IsNullOrEmpty(personname))
            {
                //REplace using delegate
                items = items.Where( r => ComparePersonName(r,personname)).ToList();
            }
            return View(items);
        }

        //Delegate function for filtering AlertUtils
        bool ComparePersonName(AlertUtils item,string personname)
        {
            string concatName = string.Format("{0} {1}", item.FirstName,item.LastName);
            if(concatName.Contains(personname)) return true;
            else return false;
        }
        //Delegate function for filtering Member
        bool ComparePersonName(Member item, string personname)
        {
            if (item.UserName.Contains(personname)) return true;
            else return false;
        }

        //Members
        public ActionResult Members(string membername)
        {
            var items = _memberservice.GetAll();
            if (!String.IsNullOrEmpty(membername))
            {
                //Replace using delegate
                items = items.Where(r => ComparePersonName(r, membername)).ToList();
            }
            return View(items);
        }


        //Index
        public ActionResult Index()
        {
            return View();
        }

        //DashBoard
        public ActionResult Stats()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ValidAlert(string AlertId)
        {
            ViewBag.AlertId = AlertId;
            Session["AlertId"] = AlertId;
            AlertStatusModel model = new AlertStatusModel();
            model.AlertId = AlertId;
            return View("ValidAlert",model);
        }

        public ActionResult ValidFound(string AlertId)
        {
            ViewBag.AlertId = AlertId;
            Session["AlertId"] = AlertId;
            AlertsFoundModel model = new AlertsFoundModel();
            model.AlertId = AlertId;
            return View("ValidFound", model);
        }


        [HttpPost]
        public ActionResult ValidFound(AlertsFoundModel model)
        {
            string AlertId = Session["AlertId"].ToString();
            var alert = _alertservice.GetById(Guid.Parse(AlertId));
            alert.Found = model.Found;
            alert.DateValidation = DateTime.Now;
            _alertservice.Update(alert);
            if (model.Found == true)
                ViewBag.Message = "Person Found";
            else ViewBag.Message = "Person Not Found";
            return View("Success");
        }

        [HttpPost]
        public ActionResult ValidAlert(AlertStatusModel model)
        {
            string AlertId = Session["AlertId"].ToString();
            var alert = _alertservice.GetById(Guid.Parse(AlertId));
            alert.ConcreteAlert = model.ConcreteAlert;
            alert.DateValidation = DateTime.Now;
            _alertservice.Update(alert);
            if (model.ConcreteAlert == true)
            ViewBag.Message = "Alert Concrete";
            else ViewBag.Message = "Alert Not Concrete";
            return View("Success");
        }
        
    }
}
