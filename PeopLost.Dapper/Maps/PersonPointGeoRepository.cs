
using System;
using PeopLost.Core.Data;
using PeopLost.Dapper.Core.Data;
using System.Data;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;
using PeopLost.Core.Domain.Maps;

namespace PeopLost.Dapper.Maps
{
    public partial class PersonPointGeoRepository:IReadOnlyRepository<PersonPointGeo>
    {

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["bdlostConnectionString"].ConnectionString);
            }
        }

        public PersonPointGeo FindById(Guid id)
        {
            PersonPointGeo personpointgeo = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                personpointgeo = cn.Query<PersonPointGeo>("SELECT * FROM PersonPointGeos WHERE ID=@ID", new { ID = id }).SingleOrDefault();
            }

            return personpointgeo;
        }

        public IEnumerable<PersonPointGeo> GetAll()
        {
            IEnumerable<PersonPointGeo> personpointgeos = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                personpointgeos = cn.Query<PersonPointGeo>("SELECT * FROM PersonPointGeos");
            }

            return personpointgeos;
        }

        public IEnumerable<PersonPointGeo> GetAll(string town)
        {
            IEnumerable<PersonPointGeo> personpointgeos = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                personpointgeos = cn.Query<PersonPointGeo>("SELECT * FROM PersonPointGeos WHERE Town=@town", new { town=town});
            }

            return personpointgeos;
        }


        /// <summary>
        /// Gets GeoLocation by person
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual IEnumerable<PersonPointGeo> GetAllbyPersonId(Guid id)
        {
            IEnumerable<PersonPointGeo> personpointgeos = null;
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                personpointgeos = cn.Query<PersonPointGeo>("SELECT * FROM PersonPointGeos WHERE PersonId=@ID", new { ID=id});
            }
            return personpointgeos;
        }
    }
}
