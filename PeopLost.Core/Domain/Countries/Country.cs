
using System;

namespace PeopLost.Core.Domain.Countries
{
    public partial class Country : BaseEntity
    {
        public Country()
        {
        }

        /// <summary>
        /// Gets or sets the ID
        /// </summary>
        public string CountryID { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get; set; }

        
    }
}
