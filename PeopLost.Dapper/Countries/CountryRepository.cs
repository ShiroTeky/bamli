using System;
using PeopLost.Core.Domain.Countries;
using PeopLost.Core.Data;
using PeopLost.Dapper.Core.Data;
using System.Data;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;

namespace PeopLost.Dapper.Countries
{
    public partial class CountryRepository:IReadOnlyRepository<Country>
    {

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["bdlostConnectionString"].ConnectionString);
            }
        }

        
        public IEnumerable<Country> GetAll()
        {
            IEnumerable<Country> Countries = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                Countries = cn.Query<Country>("SELECT * FROM Countries");
            }

            return Countries;
        }


        public Country FindById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
