using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PeopLost.Service.Countries;
using PeopLost.Core.Domain.Countries;

namespace PeopLost.WebApi.Controllers
{
    public class CountryController : ApiController
    {
        ICountryService _countryservice;

        public CountryController(ICountryService CountryService)
        {
            _countryservice = CountryService;
        }

        // GET: Countries
        [HttpGet]
        public IList<Country> GetCountries()
        {
            return _countryservice.GetAll();
        }

    }
}
