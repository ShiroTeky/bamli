
using System;
using PeopLost.Core.Domain.ConnectionHub;
using PeopLost.Core.Domain.Pictures;
using PeopLost.Core.Domain.Comments;
using System.Collections.Generic;

namespace PeopLost.Core.Domain.Members
{
    public partial class Member:BaseEntity
    {
        //private ICollection<Comment> _comments;
        
        public Member()
        {
            this.Id = Guid.NewGuid();
        }


        /// <summary>
        /// Gets or sets the username
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the email
        /// </summary>
        public string Email { get; set; }


        /// <summary>
        /// Gets or sets the gender
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the Member Image
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the Member BirthDay
        /// </summary>
        public string BirthDay { get; set; }

        public string Address { get; set; }
        /// <summary>
        /// Gets or sets the Status of Member:Admin or Not
        /// </summary>
        public bool isAdmin { get; set; }

        public string Commune { get; set; }

        public List<Connections> ConnectionId { get; set; }
    }


    public class AspUser
    {
        public Guid Id{get;set;}
        public string ImageUrl{get;set;}
        public string UserName{get;set;}
        public string Email { get; set; }
    }
}
