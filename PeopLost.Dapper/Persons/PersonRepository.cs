using System;
using PeopLost.Core.Data;
using PeopLost.Dapper.Core.Data;
using System.Data;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;
using PeopLost.Core.Domain.Persons;

namespace PeopLost.Dapper.Persons
{
    public partial class PersonRepository: IReadOnlyRepository<Person>
    {
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["bdlostConnectionString"].ConnectionString);
            }
        }

        public Person FindById(Guid id)
        {
            Person Person = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                Person = cn.Query<Person>("SELECT * FROM Persons WHERE ID=@ID", new { ID = id }).SingleOrDefault();
            }

            return Person;
        }

        public IEnumerable<Person> GetAll()
        {
            IEnumerable<Person> Persons = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                Persons = cn.Query<Person>("SELECT * FROM Persons");
            }

            return Persons;
        }

       public IEnumerable<AlertUtils> GetMyAlerts(Guid id)
        {
            IEnumerable<AlertUtils> alerts = null;
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                alerts = cn.Query<AlertUtils>("GetMyAlertsPersons", new{UserId=id},
                     commandType: CommandType.StoredProcedure);
            }
            return alerts;
        }
    }
}
