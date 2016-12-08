
using System;
using PeopLost.Core.Domain.Alertes;
using PeopLost.Core.Domain.Comments;
using PeopLost.Core.Data;
using System.Collections.Generic;
using System.Linq;
using PeopLost.Dapper.Alertes;
using PeopLost.Dapper;

namespace PeopLost.Service.Alertes
{
    public partial class AlertService: IAlertService
    {
        IRepository<Alert> alertRepository;
        AlertRepository alertdapper = new AlertRepository();

        public AlertService(IRepository<Alert> alertRepository)
        {
            this.alertRepository = alertRepository;
        }
        public void Delete(Alert Alert)
        {
            alertRepository.Delete(Alert);
        }

        public  Alert GetById(Guid AlertId)
        {
            return alertRepository.GetById(AlertId);
        }

        public void Insert(Alert Alert)
        {
            alertRepository.Insert(Alert);
        }

        public void Update(Alert Alert)
        {
            alertRepository.Update(Alert);
        }

        public IList<Alert> GetAll()
        {
            //return alertRepository.Table.ToList();
            return alertdapper.GetAll().ToList();
        }

        public IList<Alert> GetAll(string contry)
        {
            throw new NotImplementedException();
        }


        public IList<CommentUtils> GetCommentAlertbyId(Guid id)
        {
            return alertdapper.GetCommentAlertbyId(id).ToList();
        }

        public IList<AlertUtils> GetAllAlertsPersons()
        {
            return alertdapper.GetAllAlertsPersons().ToList();
        }

        public IList<AlertUtils> GetAllAlertsPersonsConcrete()
        {
            return alertdapper.GetAllAlertsPersonsConcrete().ToList();
        }
        public AlertUtils GetAlertPerson(Guid id)
        {
            return alertdapper.GetAlertPerson(id);
        }
    }
}
