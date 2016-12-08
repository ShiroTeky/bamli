using System;
using System.Collections.Generic;
namespace PeopLost.WebApi.Models
{
    public class globalGeoModels
    {
        public Guid PersonId { get; set; }

        public IList<PersonPointGeoModels> PersonPointGeos{get;set;}
    }


}
