using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PeopLost.WebApi.Models
{
    public class CountryModels
    {
        /// <summary>
        /// Gets or sets the Country ID
        /// </summary>
        public string CountryID { get; set; }

        [Display(Name = "Country Name")]
        [Required]
        public string Name { get; set; }

    }

    public class ListCountryViewModel
    {
        public IList<CountryModels> Items{get;set;}

        public ListCountryViewModel()
        {
            this.Items = new List<CountryModels>();
        }
    }
}
