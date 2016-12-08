using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PeopLost.Service.Maps;
using PeopLost.Core.Domain.Maps;
using PeopLost.WebApi.Models;
using PeopLost.Data;
using System.Web.Http.Cors;
using Newtonsoft.Json;

namespace PeopLost.WebApi.Controllers
{
    [EnableCors(origins: "http://localhost:54978", headers: "*", methods: "*")]
    public class MapController : ApiController
    {
        private IPersonPointGeoService _pointservice;

        public MapController(IPersonPointGeoService pointService)
        {
            _pointservice = pointService;
        }
        //// GET: api/Map
        [HttpGet]
        public IList<PersonPointGeo> Get()
        {
            return _pointservice.GetAll();
        }

        // GET: api/Map/5
        [EnableCors(origins: "http://localhost:58755/", headers: "*", methods: "*")]
        [HttpGet]
        public IList<PersonPointGeo> Get(string id)
        {
            Guid alertguid = Guid.Parse(id);
            return _pointservice.GetAllbyPersonId(alertguid);
        }

       
        /// <summary>
        /// Save the New Location of Person
        /// </summary>
        /// <param name="personpoints"></param>
        /// <returns></returns>
        [HttpPost]
        [EnableCors(origins: "http://localhost:54978", headers: "*", methods: "post,options")]
        public HttpResponseMessage SavePost(PersonPoints personpoints)
        {
            try
            {
                var data = personpoints;
                PersonPointGeo newPpoint = new PersonPointGeo();
                newPpoint.Latitude = data.Latitude;
                newPpoint.Longitude = data.Longitude;
                newPpoint.PersonId =Guid.Parse( data.PersonId);
                newPpoint.Id = Guid.NewGuid();
                newPpoint.MemberId =Guid.Parse( personpoints.MemberId);
                _pointservice.Insert(newPpoint);
                return Request.CreateResponse(HttpStatusCode.OK,data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(ex.Message);
            }
        }

        [HttpPut]
        //[EnableCors(origins: "http://localhost:54978", headers: "put,options", methods: "put,options")]
        public HttpResponseMessage Put(PersonPoints personpoints)
        {
            try
            {
            var data = personpoints;
            PersonPointGeo newPpoint = new PersonPointGeo();
            newPpoint.Latitude = data.Latitude;
            newPpoint.Longitude = data.Longitude;
            newPpoint.PersonId = Guid.Parse(data.PersonId);
            newPpoint.Id = Guid.NewGuid();
            newPpoint.MemberId = Guid.Parse(personpoints.MemberId);
            _pointservice.Update(newPpoint);
            return Request.CreateResponse(HttpStatusCode.OK, data);
             }
            catch (Exception ex)
            {
                return Request.CreateResponse(ex.Message);
            }
        }

        // DELETE: api/Map/5
        [HttpDelete]
        public void Delete(PersonPointGeo personpoint)
        {
            _pointservice.Delete(personpoint);
        }
    }


    public class PersonPoints
    {
        public string PersonId { get; set; }
        public double Latitude { get; set; }
        public string MemberId { get; set; }
        public double Longitude { get; set; }

    }

}
