using System;
using PeopLost.Core.Domain.Pictures;
using PeopLost.Core.Domain.Maps;


namespace PeopLost.Core.Domain.Persons
{
    public partial class Person:BaseEntity
    {

        public Person()
        {
            this.Id = Guid.NewGuid();

        }
        /// <summary>
        /// Gets or sets the firstname
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the lastname
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the gender
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the address where he disappear
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the country
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the City
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the year old
        /// </summary>
        public int YearsOld { get; set; }

        /// <summary>
        /// Gets or sets the caracteristics
        /// </summary>
        public string Caracteristics { get; set; }

        public string ImageUrl { get; set; }

        public Guid MemberId { get; set; }
    }
}
