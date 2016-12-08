
using PeopLost.Core.Domain.Comments;
using System;
using System.Collections.Generic;


namespace PeopLost.Service.Comments
{
    public partial interface ICommentService
    {
        /// <summary>
        /// Deletes a  Comment
        /// </summary>
        /// <param name="Comment">Comment</param>
        void Delete(Comment Comment);

        /// <summary>
        /// Gets a Comment
        /// </summary>
        /// <param name="CommentId">The Comment identifier</param>
        /// <returns>Comment</returns>
        Comment GetById(Guid CommentId);

        /// <summary>
        /// Inserts a Comment item
        /// </summary>
        /// <param name="Comment">Comment</param>
       void Insert(Comment Comment);

        /// <summary>
        /// Updates the Comment item
        /// </summary>
        /// <param name="Comment">Comment item</param>
        void Update(Comment Comment);
    }
}
