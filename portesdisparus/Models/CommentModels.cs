

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace PeopLost.Web.Models
{
    public class CommentModels
    {
        [Display(Name = "Comment")]
        [Required]
        public string Post { get; set; }

        [Display(Name = "Date Post")]
        public DateTime? DatePost { get; set; }

        /// <summary>
        /// Gets or sets the Alert Id
        /// </summary>
        public string AlertId { get; set; }

        /// <summary>
        /// Gets or sets the Member Id
        /// </summary>
        public string MemberId { get; set; }

        /// <summary>
        /// Gets or sets the Member Models
        /// </summary>
        public MemberModels Member { get; set; }

    }

    public class ListCommentViewModel
    {
        public IList<CommentModels> Items { set; get; }

        public ListCommentViewModel()
        {
            this.Items = new List<CommentModels>();
            //this._ListcommentViewModel = new List<CommentModels>() {
            // new CommentModels(){
            // AlertId=0,
            //  DatePost=DateTime.Now,
            //  MemberId=0,
            // Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //},
            //new CommentModels()
            //{
            //    AlertId = 0,
            //    DatePost = DateTime.Now,
            //    MemberId = 1,
            //    Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //},
            //new CommentModels()
            //{
            //    AlertId = 0,
            //    DatePost = DateTime.Now,
            //    MemberId = 2,
            //    Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //},

            //new CommentModels()
            //{
            //    AlertId = 1,
            //    DatePost = DateTime.Now,
            //    MemberId = 0,
            //    Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //},

            //new CommentModels()
            //{
            //    AlertId = 1,
            //    DatePost = DateTime.Now,
            //    MemberId = 1,
            //    Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //},

            //new CommentModels()
            //{
            //    AlertId = 1,
            //    DatePost = DateTime.Now,
            //    MemberId = 2,
            //    Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //},

            //new CommentModels()
            //{
            //    AlertId = 3,
            //    DatePost = DateTime.Now,
            //    MemberId = 0,
            //    Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //},

            //new CommentModels()
            //{
            //    AlertId = 3,
            //    DatePost = DateTime.Now,
            //    MemberId = 1,
            //    Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //},

            //new CommentModels()
            //{
            //    AlertId = 3,
            //    DatePost = DateTime.Now,
            //    MemberId = 2,
            //    Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //},

            //new CommentModels()
            //{
            //    AlertId = 4,
            //    DatePost = DateTime.Now,
            //    MemberId = 0,
            //    Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //},

            //new CommentModels()
            //{
            //    AlertId = 5,
            //    DatePost = DateTime.Now,
            //    MemberId = 0,
            //    Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //},

            //new CommentModels()
            //{
            //    AlertId = 6,
            //    DatePost = DateTime.Now,
            //    MemberId = 0,
            //    Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //},
            //new CommentModels()
            //{
            //    AlertId = 6,
            //    DatePost = DateTime.Now,
            //    MemberId = 1,
            //    Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //},


            //new CommentModels()
            //{
            //    AlertId = 7,
            //    DatePost = DateTime.Now,
            //    MemberId = 0,
            //    Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //},

            //new CommentModels()
            //{
            //    AlertId = 7,
            //    DatePost = DateTime.Now,
            //    MemberId = 1,
            //    Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //}
            //};
        


        }
    }
}
