using PeopLost.Core.Domain.Members;
using PeopLost.Service.Members;
using PeopLost.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApplication1.Controllers
{
    [EnableCors(origins: "http://localhost:54978", headers: "*", methods: "*")]
    public class MemberController : ApiController
    {
        private IMemberService _memberservice;
        
        //List<AlertModels> listmodels;
        public MemberController(IMemberService MemberService)
        {
            _memberservice = MemberService;
        }


        [HttpPost]
        [EnableCors(origins: "http://localhost:54978", headers: "*", methods: "post,options")]
        public HttpResponseMessage SaveMember(MemberModels model)
        {
            try
            {
                //Enregistrement de la personne disparue
                Member newmember = new Member() { 
                
                 Address= model.Address, Gender = model.Gender, Id=Guid.Parse( model.MemberId),
                 BirthDay= model.BirthDay
                };

                _memberservice.Insert(newmember);
                // Return the message after the Insert to the View
                return Request.CreateResponse(HttpStatusCode.OK,"Done");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(ex.Message);
            }
        }
    }
}
