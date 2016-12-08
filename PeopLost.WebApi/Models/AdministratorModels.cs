using System.ComponentModel.DataAnnotations;
using System;
namespace PeopLost.WebApi.Models
{
    public class AdministratorModels
    {

        /// <summary>
        /// Gets or sets the customer Guid
        /// </summary>
        public Guid AdminId { get; set; }

        [Display(Name="First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Gender")]
        [Required]
        public string Gender { get; set; }

        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Phone")]
        [Required]
        public string Phone { get; set; }

        [Display(Name = "Country")]
        [Required]
        public string Country { get; set; }

        [Display(Name = "City")]
        [Required]
        public string City { get; set; }

        [Display(Name = "YearsOld")]
        public int YearsOld { get; set; }
    }
}
