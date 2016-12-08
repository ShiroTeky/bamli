using System;
using PeopLost.Core.Domain.Countries;
using PeopLost.Core.Data;
using System.Collections.Generic;
using System.Linq;
using PeopLost.Dapper.Countries;

namespace PeopLost.Service.Countries
{
    public partial class CountryService:ICountryService
    {
        IRepository<Country> CountryRepository;
        CountryRepository countrydapper = new CountryRepository();

        public CountryService(IRepository<Country> CountryRepository)
        {
            this.CountryRepository = CountryRepository;
        }

        public void Delete(Country Country)
        {
            CountryRepository.Delete(Country);
        }

        public Country GetById(Guid CountryId)
        {
            return CountryRepository.GetById(CountryId);
        }

        public IList<Country> GetAll()
        {
            return countrydapper.GetAll().ToList();
        }


        public IList<Country> GetByAlertId(Guid AlertId)
        {
            return null;
        }

        public void Insert(Country Country)
        {
            CountryRepository.Insert(Country);
        }

        public void Update(Country Country)
        {
            CountryRepository.Update(Country);
        }

       
    }
}
