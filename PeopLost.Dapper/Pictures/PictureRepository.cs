using System;
using PeopLost.Core.Data;
using PeopLost.Dapper.Core.Data;
using System.Data;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;
using PeopLost.Core.Domain.Pictures;

namespace PeopLost.Dapper.Pictures
{
    public partial class PictureRepository: IReadOnlyRepository<Picture>
    {

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["bdlostConnectionString"].ConnectionString);
            }
        }

        public Picture FindById(Guid id)
        {
            Picture Picture = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                Picture = cn.Query<Picture>("SELECT * FROM Pictures WHERE ID=@ID", new { ID = id }).SingleOrDefault();
            }

            return Picture;
        }

        public IEnumerable<Picture> GetAll()
        {
            IEnumerable<Picture> Pictures = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                Pictures = cn.Query<Picture>("SELECT * FROM Pictures");
            }

            return Pictures;
        }
    }
}
