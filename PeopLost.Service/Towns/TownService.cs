using System;
using PeopLost.Core.Domain.Towns;
using PeopLost.Core.Data;
using System.Collections.Generic;
using System.Linq;
using PeopLost.Dapper.Towns;

namespace PeopLost.Service.Towns
{
    public partial class TownService:ITownService
    {
        IRepository<Town> TownRepository;
        TownRepository Towndapper = new TownRepository();

        public TownService(IRepository<Town> TownRepository)
        {
            this.TownRepository = TownRepository;
        }

        public void Delete(Town Town)
        {
            TownRepository.Delete(Town);
        }

        public Town GetById(Guid TownId)
        {
            return TownRepository.GetById(TownId);
        }

        public IList<Town> GetAll()
        {
            return Towndapper.GetAll().ToList();
        }


        public IList<Town> GetByAlertId(Guid AlertId)
        {
            return null;
        }

        public void Insert(Town Town)
        {
            TownRepository.Insert(Town);
        }

        public void Update(Town Town)
        {
            TownRepository.Update(Town);
        }

       
    }
}
