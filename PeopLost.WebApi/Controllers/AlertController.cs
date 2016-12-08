using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PeopLost.Service.Alertes;
using PeopLost.Service.Persons;
using PeopLost.Core.Domain.Alertes;
using PeopLost.WebApi.Models;
using PeopLost.Data;
using System.Web.Http.Cors;
using PeopLost.Core.Domain.Persons;
using System.Threading.Tasks;
using PeopLost.Service.Pictures;
using Newtonsoft.Json;

namespace PeopLost.WebApi.Controllers
{
    [EnableCors(origins: "http://bamliapi.azurewebsites.net", headers: "*", methods: "*")]
    public class AlertController : ApiController
    {
        private IAlertService _alertservice;
        private IPersonService _personservice;
        private IPictureService _pictureservice;
        
        //List<AlertModels> listmodels;
        public AlertController(IAlertService AlertService, IPersonService PersonService, IPictureService PictureService)
        {
            _alertservice = AlertService;
            _personservice = PersonService;
            _pictureservice = PictureService;
        }
        // GET: api/Alert
        public string Get()
        {
            var items = _alertservice.GetAllAlertsPersonsConcrete();
            var model = new ListAlertViewModel();
            foreach (var item in items)
            {
                AlertModels viewitem = new AlertModels()
                {
                    AlertId = item.AlertId.ToString(),
                    Post = item.Post,
                    PersonId = item.PersonId.ToString(),
                    DateAlert = item.DateAlert,
                    DayDisappear = item.DayDisappear,
                    LooserAddress = item.LooserAddress, 
                        FirstName = item.FirstName,
                        LastName = item.LastName,
                        ImageUrl = _pictureservice.UpdatePictureUrlToAzureStore(item.PersonId),
                        Caracteristics = item.Caracteristics,
                        City = item.City,
                        YearsOld = item.YearsOld,
                        Address = item.Address,
                        Country = item.Country,
                   
                        UserName = item.UserName,
                        ImageUrlMember = item.ImageUrlMember,
                        Phone = item.Phone

                    
                };
                model.Items.Add(viewitem);
            }
            return JsonConvert.SerializeObject(model);
            

        }

        // GET: api/Alert/5
        public Alert Get(string id)
        {
            Guid alertguid = Guid.Parse(id);
            return _alertservice.GetById(alertguid);
        }

        // POST: api/Alert
        [HttpPost]
        [EnableCors(origins: "http://bamliapi.azurewebsites.net", headers: "*", methods: "post,options")]
        public  HttpResponseMessage Post([FromBody]AlertModels model)
        {
            try 
            {
                var person = new Person()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Id = Guid.Parse( model.PersonId),
                    Country = model.Country,
                    MemberId =Guid.Parse( model.MemberId),
                    City = model.City,
                    Gender = model.Gender,
                    Address = model.Address,
                    YearsOld = model.YearsOld,
                    Caracteristics = model.Caracteristics
                };
                //Enregistrement de la personne disparue
                _personservice.Insert(person);
                var newalert = new Alert()
                {
                    Id= Guid.NewGuid(),
                    Post = model.Post,
                    DateAlert = DateTime.Now,
                    DayDisappear = model.DayDisappear,
                    LooserAddress = model.LooserAddress,
                    PersonId = person.Id ,
                    UserId =Guid.Parse( model.MemberId)
                };
                //Enregistrement de l'alerte
                _alertservice.Insert(newalert);
                //
                //SavePicture(model.PhotoUrl);
                // Return the message after the Insert to the View
                 return Request.CreateResponse(HttpStatusCode.OK, 
                     string.Format("Record done. {0}, will be found",person.LastName));
                
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(ex.InnerException.ToString());
            }
        }

        // PUT: api/Alert/5
        [HttpPatch]
        [HttpPut]
        //[EnableCors(origins: "http://localhost:54978", headers: "put,options", methods: "put,options")]
        public HttpResponseMessage Put(Guid id, [FromBody]AlertModels model)
        {

            try
            {

                var person = _personservice.GetById(id);


                    person.FirstName = model.FirstName;
                    person.LastName = model.LastName;
                    //Id = Guid.Parse(model.PersonId),
                    person.Country = model.Country;
                    person.MemberId = Guid.Parse(model.MemberId);
                    person.City = model.City;
                    person.Gender = model.Gender;
                    person.Address = model.Address;
                    person.YearsOld = model.YearsOld;
                    person.Caracteristics = model.Caracteristics;
                
                //Enregistrement de la personne disparue
                _personservice.Update(person);
                var newalert = new Alert()
                {
                    Id = Guid.Parse(model.AlertId),
                    Post = model.Post,
                    DayDisappear = model.DayDisappear,
                    LooserAddress = model.LooserAddress,
                    PersonId = Guid.Parse(model.PersonId),
                    UserId = Guid.Parse(model.MemberId)
                };
                //Enregistrement de l'alerte
                _alertservice.Update(newalert);
                //
                // Return the message after the Insert to the View
                return Request.CreateResponse(HttpStatusCode.OK,string.Format("Update done for {0}",
                     person.FirstName));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(ex.InnerException.ToString());
            }
        }

        // DELETE: api/Alert/5
        public void Delete(Guid id)
        {
           
        }


        
    }
}
