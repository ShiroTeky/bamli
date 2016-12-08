using PeopLost.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PeopLost.Core.Domain.Persons;
using PeopLost.Data;
using PeopLost.Service.Persons;

namespace portesdisparus.Controllers
{
    public class PersonController : Controller
    {
        private IPersonService _personService;

        public PersonController(IPersonService PersonService)
        {
            _personService = PersonService;
        }
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        //GET: Create Person
        public ActionResult Create()
        {
            Person model = new Person();
            return View(model);
        }


        //POST: Create Person
        [HttpPost]
        public ActionResult Create(Person model)
        {
            _personService.Insert(model);
            return View(model);
        }

        // GET: List
        public ActionResult List()
        {  
           var model = new ListPersonViewModel();
           return View(model);
        }

        
    }
}