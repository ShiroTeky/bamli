using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace PeopLost.SignalRMappingAuth
{
    public class MemberContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<ConnectionHub> Connections { get; set; }
    }

    public class Member
    {
        [Key]
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

        /// <summary>
        /// Address use to locate the people
        /// </summary>
        public string Address { get; set; }
        
        /// <summary>
        /// Gets or sets the Status of Member:Admin or Not
        /// </summary>
        public bool isAdmin { get; set; }

        /// <summary>
        /// Gets or sets the Id connection list of Member
        /// </summary>
        public ConnectionHub ConnectionHubs{get;set;}
    }

    public class ConnectionHub
    {
        [Key]
        public string ConnectionID { get; set; }
        public string UserAgent { get; set; }
        public bool Connected { get; set; }
    }
}