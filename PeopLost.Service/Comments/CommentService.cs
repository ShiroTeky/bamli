using System;
using PeopLost.Core.Domain.Comments;
using PeopLost.Core.Data;
using System.Collections.Generic;

namespace PeopLost.Service.Comments
{
    public partial class CommentService:ICommentService
    {
        IRepository<Comment> commentRepository;
        

        public CommentService(IRepository<Comment> commentRepository)
        {
            this.commentRepository = commentRepository;
        }

        public void Delete(Comment Comment)
        {
            commentRepository.Delete(Comment);
        }

        public Comment GetById(Guid CommentId)
        {
            return commentRepository.GetById(CommentId);
        }

        public IList<Comment> GetByAlertId(Guid AlertId)
        {
            return null;
        }

        public void Insert(Comment Comment)
        {
            commentRepository.Insert(Comment);
        }

        public void Update(Comment Comment)
        {
            commentRepository.Update(Comment);
        }

       
    }
}
