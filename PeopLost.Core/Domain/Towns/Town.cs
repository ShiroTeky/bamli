using System;
using PeopLost.Core.Domain.Countries;

namespace PeopLost.Core.Domain.Towns
{
    public partial class Town:BaseEntity
    {
        public Town()
        {
        }

        /// <summary>
        /// Gets or sets the ID
        /// </summary>
        public string TownID { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Country
        /// </summary>
        public Country Country { get; set; }

        /// <summary>
        /// Gets or sets the Country ID
        /// </summary>
        public Guid CountryID { get; set; }

        
    }
}
