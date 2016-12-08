using System;
using PeopLost.Core.Domain.Administrators;
using PeopLost.Core.Data;

namespace PeopLost.Service.Administrators
{
    public  class AdministratorService: IAdministratorService
    {
        IRepository<Administrator> adminRepository;

        public AdministratorService(IRepository<Administrator> adminRepository)
        {
            this.adminRepository = adminRepository;
        }

        public virtual void Delete(Administrator Administrator)
        {
            adminRepository.Delete(Administrator);
        }

        public virtual Administrator GetById(int AdministratorId)
        {
            return adminRepository.GetById(AdministratorId);
        }

        public virtual void Insert(Administrator Administrator)
        {
            adminRepository.Insert(Administrator);
        }

        public virtual void Update(Administrator Administrator)
        {
            adminRepository.Update(Administrator);
        }


        public bool ValidateAlert(Guid id, bool status)
        {
            //HERE THE CODE FOR SEND NOTIFICATION
            return false;
        }
    }
}
