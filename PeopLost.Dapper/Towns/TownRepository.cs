using System;
using PeopLost.Core.Domain.Towns;
using PeopLost.Core.Data;
using PeopLost.Dapper.Core.Data;
using System.Data;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;

namespace PeopLost.Dapper.Towns
{
    public partial class TownRepository:IReadOnlyRepository<Town>
    {

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["bdlostConnectionString"].ConnectionString);
            }
        }

        
        public IEnumerable<Town> GetAll()
        {
            IEnumerable<Town> Towns = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                Towns = cn.Query<Town>("SELECT * FROM Towns");
            }

            return Towns;
        }


        public Town FindById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
