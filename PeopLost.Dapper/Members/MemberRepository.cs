
using System;
using PeopLost.Core.Data;
using PeopLost.Dapper.Core.Data;
using System.Data;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;
using PeopLost.Core.Domain.Members;
using PeopLost.Core.Domain.ConnectionHub;
using PeopLost.Core.Domain.Persons;

namespace PeopLost.Dapper.Members
{
    public class MemberRepository: IReadOnlyRepository<Member>
    {
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["bdlostConnectionString"].ConnectionString);
            }
        }

        public Member FindById(Guid id)
        {
            Member member = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                member = cn.Query<Member>("SELECT * FROM Members WHERE ID=@ID", new { ID = id }).SingleOrDefault();
            }

            return member;
        }

        public IEnumerable<Member> GetAll()
        {
            IEnumerable<Member> members = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                members = cn.Query<Member>("SELECT * FROM Members");
            }

            return members;
        }

        public Member GetByEmail(string email)
        {
            Member user = null;
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                user = cn.Query<Member>("SELECT Id,ImageUrl,UserName,Email FROM Members WHERE Email =@email", new { email =email }).SingleOrDefault();
            }

            return user;

        }

        //Get the ConnectionId
        public Connections GetConnectionHub(Guid id)
        {
            Connections connHub = null;
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                connHub = cn.Query<Connections>("SELECT Id,Connected,UserAgent,Member_Id, FROM Connections WHERE Member_Id =@id", 
                    new { id = id }).SingleOrDefault();
            }

            return connHub;
        }

        public List<string> GetListConnectionsByAddress(string address)
        {
            List<string> connHubs = null;
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                connHubs = cn.Query<string>("GetListConnectionsByAddress",new {address = address},
                     commandType: CommandType.StoredProcedure).ToList();
            }

            return connHubs;
        }

        
    }
}
