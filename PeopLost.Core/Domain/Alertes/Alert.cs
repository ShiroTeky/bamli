using PeopLost.Core.Domain.Comments;
using PeopLost.Core.Domain.Members;
using PeopLost.Core.Domain.Persons;
using System;


namespace PeopLost.Core.Domain.Alertes
{
    public partial class Alert : BaseEntity
    {

        public Alert()
        {
        }
        /// <summary>
        /// Gets or sets the post
        /// </summary>
        public string Post { get; set; }

        public string LooserAddress { get; set; } 

        /// <summary>
        /// Gets or sets the Date of Post
        /// </summary>
        public DateTime? DateAlert { get; set; }

        /// <summary>
        /// Gets or sets the Date of disappearing
        /// </summary>
        public DateTime? DayDisappear { get; set; }

        /// <summary>
        /// Gets or sets the Date of Validation of the Alert as Concrete
        /// </summary>
        public DateTime? DateValidation { get; set; }
        
        /// <summary>
        /// Gets or sets the Person Id
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Gets or sets the User Id  
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// Gets or sets the status of the alert: verified or not
        /// </summary>
        public bool ConcreteAlert { get; set; }

        /// <summary>
        /// Gets or sets the User
        /// </summary>
        public virtual Member Member { get; set; }

        /// <summary>
        /// Gets or sets the Person
        /// </summary>
        public virtual Person Person { get; set; }

        //public virtual ICollection<Comment> Comments
        //{
        //    get { return _comments ?? (_comments = new List<Comment>()); }
        //    protected set { _comments = value; }
        
        //}
        public bool Found { get; set; }
    }
}
