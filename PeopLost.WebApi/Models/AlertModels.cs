using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PeopLost.WebApi.Models
{
    
    public class AlertModels
    {
        public AlertModels()
        {
            PersonId = Guid.NewGuid().ToString();
        }

        public string AlertId { get; set; }

        public string PersonId { get; set; }

        public string MemberId { get; set; }


        [Display(Name = "Comment")]
        [Required]
        public string Post { get; set; }

        public DateTime? DateAlert { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Gender")]
        [Required]
        public string Gender { get; set; }

        [Display(Name = "Day of the Disappearing")]
        [Required]
        public DateTime DayDisappear { get; set; }

        [Display(Name = "Adress or street where he disappeared")]
        [Required]
        public string LooserAddress { get; set; }

        [Display(Name = "Adress or street")]
        [Required]
        public string Address { get; set; }

        [Display(Name = "Country")]
        [Required]
        public string Country { get; set; }

        [Display(Name = "City")]
        [Required]
        public string City { get; set; }

        [Display(Name = "Year Old")]
        [Required]
        public int YearsOld { get; set; }

        [Display(Name = "Caracteristics")]
        [Required]
        public string Caracteristics { get; set; }
        public bool Found { get; set; }

        public MemberModels Member { get; set; }

        public PersonModels Person { get; set; }


        [Display(Name = "UserName")]
        public string UserName { get; set; }

       
        public string ImageUrlMember { get; set; }
        public string ImageUrl { get; set; }
        public string Phone { get; set; }
        /// <summary>
        /// Gets or sets the status of the alert: verified or not
        /// </summary>
        public bool ConcreteAlert { get; set; }

        
    }

    public class ListAlertViewModel
    {
        public IList<AlertModels> Items { get; set; }

        public ListAlertViewModel()
        {
            Items = new List<AlertModels>();
            
        }
    }
    
}
