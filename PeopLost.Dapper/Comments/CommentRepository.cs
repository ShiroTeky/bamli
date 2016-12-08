using System;
using PeopLost.Core.Domain.Comments;
using PeopLost.Core.Data;
using PeopLost.Dapper.Core.Data;
using System.Data;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;

namespace PeopLost.Dapper.Comments
{
    public partial class CommentRepository:IReadOnlyRepository<Comment>
    {

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["bdlostConnectionString"].ConnectionString);
            }
        }

        public Comment FindById(Guid id)
        {
            Comment Comment = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                Comment = cn.Query<Comment>("SELECT * FROM Comments WHERE ID=@ID", new { ID = id }).SingleOrDefault();
            }

            return Comment;
        }

        public IEnumerable<Comment> GetAll()
        {
            IEnumerable<Comment> Comments = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                Comments = cn.Query<Comment>("SELECT * FROM Comments");
            }

            return Comments;
        }

    }
}
