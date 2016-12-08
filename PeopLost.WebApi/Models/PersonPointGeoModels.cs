
using System;
using System.Collections.Generic;
namespace PeopLost.WebApi.Models
{
    public class PersonPointGeoModels
    {
        /// <summary>
        /// Gets or sets the people id
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Gets or sets the Member id
        /// </summary>
        public Guid MemberId { get; set; }

        /// <summary>
        /// Gets or sets the current address where user sees him
        /// </summary>
        public string CurrentAddress { get; set; }

        /// <summary>
        /// Gets or sets the longitude
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or sets the latitude
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets the town
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// Gets or sets the dateMapping
        /// </summary>
        public DateTime? DateMapping { get; set; }

    }

    public class ListPointGeoViewModels
    {
        public IList<PersonPointGeoModels> _Items { get; set; }

        public ListPointGeoViewModels()
        {
            this._Items = new List<PersonPointGeoModels>();
           // this._listpointGeoViewModel = new List<PersonPointGeoModels>(){ 
           //     new PersonPointGeoModels() {
           //     CurrentAddress = "Blockhauss",
           //     DateMapping = DateTime.Now,
           //     Town = "Abidjan",
           //     PersonId = 1,
           //     MemberId = 0,
           //     Latitude = 5.325111,
           //     Longitude = -4.001951
           // },
           // new PersonPointGeoModels()
           // {
           //     CurrentAddress = "Cocody",
           //     DateMapping = DateTime.Now,
           //     Town = "Abidjan",
           //     PersonId = 1,
           //     MemberId = 0,
           //     Latitude = 5.625111,
           //     Longitude = -3.001951
           // },
           // new PersonPointGeoModels()
           // {
           //     CurrentAddress = "Cocody",
           //     DateMapping = DateTime.Now,
           //     Town = "Abidjan",
           //     PersonId = 1,
           //     MemberId = 1,
           //     Latitude = 6.325111,
           //     Longitude = -5.001951
           // }
           //};
        }
    }
}
