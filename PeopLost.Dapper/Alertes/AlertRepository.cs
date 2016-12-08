
using System;
using PeopLost.Core.Domain.Alertes;
using PeopLost.Core.Domain.Comments;
using PeopLost.Core.Data;
using System.Collections.Generic;
using System.Linq;
using PeopLost.Dapper.Core.Data;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using PeopLost.Data;
using System.Configuration;

namespace PeopLost.Dapper.Alertes
{
    public partial class AlertRepository:IReadOnlyRepository<Alert>
    {
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["bdlostConnectionString"].ConnectionString);
            }
        }

        public Alert FindById(Guid id)
        {
            Alert alert = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                alert = cn.Query<Alert>("SELECT * FROM Alerts WHERE ID=@ID", new { ID = id }).SingleOrDefault();
            }

            return alert;
        }

        public IEnumerable<Alert> GetAll()
        {
            IEnumerable<Alert> alerts = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                alerts = cn.Query<Alert>("SELECT * FROM Alerts");
            }

            return alerts;
        }

        public virtual IEnumerable<CommentUtils> GetCommentAlertbyId(Guid id)
        {
            IEnumerable<CommentUtils> comments = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                comments = cn.Query<CommentUtils>("GetCommentAlertbyId", 
                    new { ID = id }, commandType: CommandType.StoredProcedure);
            }

            return comments;
        }

        public virtual IEnumerable<AlertUtils> GetAllAlertsPersons()
        {
            IEnumerable<AlertUtils> alerts = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                alerts = cn.Query<AlertUtils>("GetAllAlertsPersons",
                     commandType: CommandType.StoredProcedure);
            }

            return alerts;
        }

        public virtual IEnumerable<AlertUtils> GetAllAlertsPersonsConcrete()
        {
            IEnumerable<AlertUtils> alerts = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                alerts = cn.Query<AlertUtils>("GetAllAlertsPersonsConcrete",
                     commandType: CommandType.StoredProcedure);
            }

            return alerts;
        }


        public virtual AlertUtils GetAlertPerson(Guid id)
        {
            AlertUtils alert = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                alert = cn.Query<AlertUtils>("GetAlertPerson",new {AlertId = id},
                     commandType: CommandType.StoredProcedure).SingleOrDefault();
            }

            return alert;
        }
    }

    

}
