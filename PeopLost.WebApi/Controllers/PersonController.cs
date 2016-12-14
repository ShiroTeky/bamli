using PeopLost.Core.Domain.Persons;
using PeopLost.Service.Alertes;
using PeopLost.Service.Persons;
using PeopLost.Service.Pictures;
using PeopLost.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PeopLost.WebApi.Controllers
{
    [EnableCors(origins: "http://bamliapi.azurewebsites.net", headers: "*", methods: "*")]
    public class PersonController : ApiController
    {
        private IAlertService _alertservice;
        private IPersonService _personservice;
        private IPictureService _pictureservice;

        //List<AlertModels> listmodels;
        public PersonController(IAlertService AlertService, IPersonService PersonService, IPictureService PictureService)
        {
            _alertservice = AlertService;
            _personservice = PersonService;
            _pictureservice = PictureService;
        }

    }
}
