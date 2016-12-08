using PeopLost.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PeopLost.Data;
using PeopLost.Service.Alertes;
using PeopLost.Service.Persons;
using PeopLost.Service.Maps;
using PeopLost.Service.Comments;
using PeopLost.Core.Domain.Persons;
using PeopLost.Core.Domain.Alertes;
using PeopLost.Core.Domain.Comments;
using PeopLost.Core.Domain.Maps;
using System.Web.Helpers;
using PeopLost.Service.Pictures;
using System.Threading.Tasks;


namespace portesdisparus.Controllers
{
    public class AlertController : Controller
    {
        private IAlertService _alertservice;
        private IPersonService _personservice;
        private ICommentService _commentservice;
        private IPersonPointGeoService _pointservice;
        private IPictureService _pictureservice;

        public AlertController(IAlertService Alertservice, IPersonService PersonService,
            ICommentService CommentService, 
            IPersonPointGeoService PointService,IPictureService PictureService)
        {
            _alertservice = Alertservice;
            _personservice = PersonService;
            _commentservice = CommentService;
            _pointservice = PointService;
            _pictureservice = PictureService;
        }
        // GET: Alert
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// GET: Create New Alert
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Create()
        {
            AlertModels model = new AlertModels();

            ViewBag.PersonId = model.PersonId;
            return View(model);
        }

        public ActionResult Edit(string id)
        {
            Guid alertguid = Guid.Parse(id);

            var item = _alertservice.GetAlertPerson(alertguid);
            var model = new AlertModels()
            {
                AlertId = item.AlertId,
                Post = item.Post,
                PersonId = item.PersonId,
                DayDisappear = item.DayDisappear,
                LooserAddress = item.LooserAddress,
                Person = new PersonModels()
                {
                    PersonId = item.PersonId,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    ImageUrl = _pictureservice.UpdatePictureUrlToAzureStore(item.PersonId),
                    Caracteristics = item.Caracteristics,
                    City = item.City,
                    YearsOld = item.YearsOld,
                    Address = item.Address,
                    Country = item.Country
                }
                
            };
            ViewBag.PersonId = model.PersonId;
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(AlertModels model)
        {
            return RedirectToAction("MyAlerts");
        }

        [ChildActionOnly]
        //Ecrire une procedure stockee et utilisation de dapper . Creation d'une classe AlertUtils
        public PartialViewResult _Person(string AlertId)
        {
            Guid alertguid = Guid.Parse(AlertId);
            var item = _alertservice.GetAlertPerson(alertguid);
            var model = new AlertModels()
            {
                AlertId = item.AlertId,
                Post = item.Post,
                PersonId = item.PersonId,
                DayDisappear = item.DayDisappear,
                LooserAddress = item.LooserAddress,
                Person = new PersonModels()
                {
                    PersonId = item.PersonId,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    ImageUrl = _pictureservice.UpdatePictureUrlToAzureStore(item.PersonId),
                    Caracteristics = item.Caracteristics,
                    City = item.City,
                    YearsOld = item.YearsOld,
                    Address = item.Address,
                    Country = item.Country
                },
                Member = new MemberModels()
                {
                    UserName = item.UserName,
                    ImageUrl = item.ImageUrlMember,
                    Phone = item.Phone

                }
            };
            ViewBag.AlertId = AlertId;
            return PartialView("_Person",model);
        }

        //public ActionResult List()
        //{
        //    var items = _alertservice.GetAllAlertsPersonsConcrete();
        //    var model = new ListAlertViewModel();
        //    foreach(var item in items)
        //    {
        //        AlertModels viewitem = new AlertModels()
        //        {
        //            AlertId = item.AlertId,
        //            Post = item.Post,
        //            PersonId = item.PersonId,
        //            DateAlert = item.DateAlert,
        //            DayDisappear = item.DayDisappear,
        //            LooserAddress = item.LooserAddress,
        //            Person = new PersonModels()
        //            {
        //                PersonId = item.PersonId,
        //                FirstName = item.FirstName,
        //                LastName = item.LastName,
        //                ImageUrl = _pictureservice.UpdatePictureUrlToAzureStore(item.PersonId),
        //                Caracteristics = item.Caracteristics,
        //                City = item.City,
        //                YearsOld = item.YearsOld,
        //                Address = item.Address,
        //                Country = item.Country
        //            },
        //            Member = new MemberModels()
        //            {
        //                UserName = item.UserName,
        //                ImageUrl = item.ImageUrlMember,
        //                Phone = item.Phone

        //            }
        //        };
        //        model.Items.Add(viewitem);
        //    }
        //    return View(model);
        //}


        public ActionResult List(string personname)
        {
            var items = _alertservice.GetAllAlertsPersonsConcrete();
            var model = new ListAlertViewModel();

            if (!String.IsNullOrEmpty(personname))
            {
                foreach (var item in items)
                {
                    string concatname = string.Format("{0} {1}", item.FirstName, item.LastName);
                    if (concatname.Contains(personname))
                    {
                        AlertModels viewitem = new AlertModels()
                        {
                            AlertId = item.AlertId,
                            Post = item.Post,
                            PersonId = item.PersonId,
                            DateAlert = item.DateAlert,
                            DayDisappear = item.DayDisappear,
                            LooserAddress = item.LooserAddress,
                            Person = new PersonModels()
                            {
                                PersonId = item.PersonId,
                                FirstName = item.FirstName,
                                LastName = item.LastName,
                                ImageUrl = _pictureservice.UpdatePictureUrlToAzureStore(item.PersonId),
                                Caracteristics = item.Caracteristics,
                                City = item.City,
                                YearsOld = item.YearsOld,
                                Address = item.Address,
                                Country = item.Country
                            },
                            Member = new MemberModels()
                            {
                                UserName = item.UserName,
                                ImageUrl = item.ImageUrlMember,
                                Phone = item.Phone

                            }
                        };
                        model.Items.Add(viewitem);
                    }
                }

            }
            else
            {
                foreach (var item in items)
                {
                    AlertModels viewitem = new AlertModels()
                    {
                        AlertId = item.AlertId,
                        Post = item.Post,
                        PersonId = item.PersonId,
                        DateAlert = item.DateAlert,
                        DayDisappear = item.DayDisappear,
                        LooserAddress = item.LooserAddress,
                        Person = new PersonModels()
                        {
                            PersonId = item.PersonId,
                            FirstName = item.FirstName,
                            LastName = item.LastName,
                            ImageUrl = _pictureservice.UpdatePictureUrlToAzureStore(item.PersonId),
                            Caracteristics = item.Caracteristics,
                            City = item.City,
                            YearsOld = item.YearsOld,
                            Address = item.Address,
                            Country = item.Country
                        },
                        Member = new MemberModels()
                        {
                            UserName = item.UserName,
                            ImageUrl = item.ImageUrlMember,
                            Phone = item.Phone

                        }
                    };
                    model.Items.Add(viewitem);
                }

                
            }
            return View(model);
        }
    
        /// List of comment of Alert ID
        // Get Alert Comments
        public IList<CommentModels> GetCommentViewModel(string idalert)
        {
            Guid alertguid = Guid.Parse(idalert);
            var comments = _alertservice.GetCommentAlertbyId(alertguid);
            var models = new List<CommentModels>();

            foreach (var item in comments)
            {
                CommentModels commentModel = new CommentModels()
                {
                    DatePost = item.DatePost,
                    Post = item.Post,
                    Member = new MemberModels()
                    {
                        UserName = item.UserName,
                        ImageUrl = item.ImageUrl
                    }

                };
                models.Add(commentModel);
            }
            return models;
        }

        [ChildActionOnly]
        public PartialViewResult _Comment(string AlertId)
        {
            Guid alertguid = Guid.Parse(AlertId);
            ViewBag.AlertId = AlertId;
            var comments = GetCommentViewModel(AlertId);
            return PartialView("_Comment", comments);

        }

       
        /// <summary>
        /// Display the Alert Item
        /// </summary>
        /// <param name="AlertId"></param>
        /// <returns></returns>
        /// NE PAS RECHARGER LA PAGE
        public ActionResult Item(string AlertId)
        {
            Guid alertGuid = Guid.Parse(AlertId);
            var item = _alertservice.GetAlertPerson(alertGuid);
            var model = new AlertModels()
                {
                    AlertId = item.AlertId,
                    Post = item.Post,
                    PersonId = item.PersonId,
                    DayDisappear = item.DayDisappear,
                    LooserAddress = item.LooserAddress,
                    Found= item.Found,

                    Person = new PersonModels()
                    {
                        PersonId = item.PersonId,
                        FirstName = item.FirstName,
                        LastName = item.LastName,
                        ImageUrl = _pictureservice.UpdatePictureUrlToAzureStore(item.PersonId),
                        Caracteristics = item.Caracteristics,
                        City = item.City,
                        YearsOld = item.YearsOld,
                        Address = item.Address,
                        Country = item.Country
                    },
                    Member = new MemberModels()
                    {
                        UserName = item.UserName,
                        ImageUrl = item.ImageUrlMember,
                        Phone = item.Phone

                    }
                };
            ViewBag.PersonId = item.PersonId;
            return View(model);
        }


        //Bout de code pour le retour en JSON
        public JsonResult GetPersonPoint(string PersonId)
        {
            Guid personguid = Guid.Parse(PersonId);
            var datas = _pointservice.GetAllbyPersonId(personguid);
            ViewBag.PersonId = PersonId;
            return Json(datas,JsonRequestBehavior.AllowGet);

        }
        //Fin de bout de code pour le retour en JSON

        //Bout de code pour l'enregistrment de la nouvelle position 
        [HttpPost]
        public ActionResult GetPersonPoint(HttpRequestBase newMarkers)
        {
            var datas = newMarkers;
            return RedirectToAction("Item", ViewBag.PersonId);

        }
        //Fin de bout de code pour le retour en JSON


        //Bout de code pour l'enregistrement de la photo dans azure
        [HttpPost]
        [ValidateAntiForgeryToken] 
        public async Task<ActionResult> SavePhoto(string _pg,HttpPostedFileBase InputFile)
        {
            try
            {
                if (InputFile !=null)
                {
                    var personGuid = Guid.Parse(_pg);
                    ViewBag.PhotoUrl = await _pictureservice.UploadToAzureStorage(personGuid, InputFile);
                    ViewBag.Message = "Save successed";
                }
            }
            catch(Exception ex){
                Console.Out.Write(ex.Message);
                ViewBag.Message = "Save failed";

            }
           return View("Success");
        }


        public ActionResult EditPhoto(string id)
        {
            ViewBag.PersonId = id;
            return View("EditPhoto");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditPhoto(string _pg, HttpPostedFileBase InputFile)
        {
            try
            {
                if (InputFile != null)
                {
                    var personGuid = Guid.Parse(_pg);
                    ViewBag.PhotoUrl = await _pictureservice.UploadToAzureStorage(personGuid, InputFile);
                    ViewBag.Message = "Edited successed";
                }
            }
            catch (Exception ex)
            {
                Console.Out.Write(ex.Message);
                ViewBag.Message = "Edited failed";

            }
            return View("EditOk");
        }
        //Display the PartialView for the Map
        public PartialViewResult _Map(string personId)
        {
            //var json = _pointservice.GetAllbyPersonId(personId).ToList();
            ViewBag.PersonId = personId;
            return PartialView("_Map");
        }

        //Display the list of Alert create by user
        public ActionResult MyAlerts()
        {
            Guid userid = Guid.Parse(Session["userid"].ToString());
            var model = _personservice.GetMyAlertsPersons(userid);
            return View("MyAlerts",model);
        }
       
    }
}