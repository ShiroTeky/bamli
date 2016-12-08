using PeopLost.Core.Domain.Alertes;
using PeopLost.Core.Domain.Members;
using System;


namespace PeopLost.Core.Domain.Comments
{
    public partial class Comment:BaseEntity
    {
        public Comment()
        {
            this.Id = Guid.NewGuid();
        }
        /// <summary>
        /// Gets or sets the post
        /// </summary>
        public string Post { get; set; }

        /// <summary>
        /// Gets or sets the Date of Post
        /// </summary>
        public DateTime? DatePost { get; set; }

        /// <summary>
        /// Gets or sets the Alert Id
        /// </summary>
        public Guid AlertId { get; set; }

        /// <summary>
        /// Gets or sets the Member Id
        /// </summary>
        public Guid MemberId { get; set; }
        // Add the Alert Here ; public virtual Alerte
        public virtual Alert Alert { get; set; } 

        //// Add the Member Here; public virtual Member
        public virtual Member Member { get; set; }
    }
}
