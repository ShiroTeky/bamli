using PeopLost.Service.Comments;
using PeopLost.Service.Alertes;
using PeopLost.Core.Domain.Comments;
using PeopLost.WebApi.Models;
using PeopLost.Data;
using System.Linq;
using System.Web.Http;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http.Cors;
using System;
using System.Net;

namespace PeopLost.WebApi.Controllers
{
    [EnableCors(origins: "http://localhost:54978", headers: "*", methods: "*")]
    public class CommentController : ApiController
    {
        ICommentService _commentservice;
        IAlertService _alertservice;

                
        public CommentController(ICommentService CommentService, IAlertService AlertService)
        {
            _commentservice = CommentService;
            _alertservice = AlertService;
        }

        // GET: Comment
        public Comment GetComment(string commentId)
        {
            var commentguid = Guid.Parse(commentId);
            return _commentservice.GetById(commentguid);
        }

        [HttpGet]
        [EnableCors(origins: "http://localhost:54978", headers: "*", methods: "post,options")]
        public HttpResponseMessage Comment(string AlertId)
        {
            try { 
                    var comments = _alertservice.GetCommentAlertbyId(Guid.Parse(AlertId));
                    return Request.CreateResponse(HttpStatusCode.OK, comments);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(ex.InnerException.ToString());
            }
        }

        [NonAction]
        public IList<PeopLost.Dapper.CommentUtils> GetCommentsbyAlert(string alertId)
        {
            var alertguid = Guid.Parse(alertId);
            return _alertservice.GetCommentAlertbyId(alertguid) ;
        }

        [HttpPost]
        [EnableCors(origins: "http://localhost:54978", headers: "*", methods: "post,options")]
        public HttpResponseMessage SaveComment(CommentModels comment)
        {
            Comment newComment = new Comment();
            try
            { 
                newComment.Post = comment.Post;
                newComment.MemberId =Guid.Parse( comment.MemberId);
                newComment.DatePost = DateTime.Now;
                newComment.AlertId =Guid.Parse( comment.AlertId);
                _commentservice.Insert(newComment);
                var comments = _alertservice.GetCommentAlertbyId(Guid.Parse(comment.AlertId));
                return Request.CreateResponse(HttpStatusCode.OK,comments);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(ex.InnerException.ToString());
            }
        }
    }

}