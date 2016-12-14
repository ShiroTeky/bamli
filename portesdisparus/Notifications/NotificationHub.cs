using System;
using System.Linq;
using Microsoft.AspNet.SignalR;
using PeopLost.Data;
using PeopLost.Dapper.Alertes;
using PeopLost.Core.Domain.Alertes;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.AspNet.SignalR.Hubs;
using System.Data.Entity;
using System.Data;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using PeopLost.Dapper.Members;
using PeopLost.SignalRMappingAuth;
using System.Collections.Generic;


namespace PeopLost.Notifications
{
    //[Authorize] 
    [HubName("notificationHub")]
    public class NotificationHub : Hub
    {
        private static readonly ConcurrentDictionary<string, Member> Users = new ConcurrentDictionary<string, Member>(StringComparer.InvariantCultureIgnoreCase);
        private MemberRepository dapperMember = new MemberRepository();

        //ON Processing....
        //#region Methods
        //public override Task OnConnected()
        //{
        //    var name = Context.User.Identity.Name;
        //    using (var db = new MemberContext())
        //    {
        //        var user = db.Members
        //            .Include(u=>u.ConnectionHubs)
        //            .SingleOrDefault(u => u.UserName == name);

        //        if (user == null)
        //        {
        //            user = new Member
        //            {
        //                UserName = name,
        //                ConnectionHubs = new ConnectionHub()
        //            };
        //            db.Members.Add(user);
        //        }

        //        user.ConnectionHubs =new ConnectionHub
        //        {
        //            ConnectionID = Context.ConnectionId,
        //            UserAgent = Context.Request.Headers["User-Agent"],
        //            Connected = true
        //        };
        //        db.SaveChanges();
        //    }
        //    return base.OnConnected();
        //}

        //public override Task OnDisconnected(bool stopCalled)
        //{
        //    using (var db = new MemberContext())
        //    {
        //        var connection = db.Connections.Find(Context.ConnectionId);
        //        connection.Connected = false;
        //        db.SaveChanges();
        //    }
        //    return base.OnDisconnected(stopCalled);
        //}
        //#endregion



        [HubMethodName("sendNotifications")]
        public void SendNotifications()
        {
            string connstr = ConfigurationManager.ConnectionStrings["sqlConnString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstr);
            
                conn.Open();
                string query = "SELECT [Id], [Post], [DateAlert], [PersonId],[LooserAddress], [UserId],[ConcreteAlert],[DateValidation] FROM [dbo].[Alerts] WHERE [ConcreteAlert]=1 And [DateValidation] = @CurrentDate";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        cmd.Notification = null;
                        DataTable dtbl = new DataTable();
                        cmd.Parameters.AddWithValue("@CurrentDate", DateTime.UtcNow.Date);
                        SqlDependency sqlDep = new SqlDependency(cmd);
                        sqlDep.OnChange += new OnChangeEventHandler(sqlDep_OnChange);

                        if (conn.State == System.Data.ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        var reader = cmd.ExecuteReader();
                        dtbl.Load(reader);
                        List<Alert> alerts = new List<Alert>();
                        if (dtbl.Rows.Count > 0)
                        {
                            foreach (DataRow dt in dtbl.Rows)
                            {
                                Guid Id = Guid.Parse(dt["Id"].ToString());
                                DateTime DateAlert = DateTime.Parse(dt["DateAlert"].ToString());
                                string Post = dt["Post"].ToString();
                                string LooserAddress = dt["LooserAddress"].ToString();
                                Boolean ConcreteAlert = Convert.ToBoolean(dt["ConcreteAlert"]);
                                DateTime DateValidation = DateTime.Parse(dt["DateValidation"].ToString());
                                Guid PersonId = Guid.Parse(dt["PersonId"].ToString());
                                Guid UserId = Guid.Parse(dt["UserId"].ToString());

                                alerts.Add(new Alert()
                                {
                                    Id = Id,
                                    DateValidation = DateValidation,
                                    PersonId = PersonId,
                                    UserId = UserId,
                                    ConcreteAlert = ConcreteAlert,
                                    Post = Post,
                                    DateAlert = DateAlert,
                                    LooserAddress = LooserAddress
                                });
                            }
                        }
                        conn.Close();
                        //Get the Connection Id Mapping From Database with Member //Rewrite this method to add the country or the city 
                        //var db = new MemberContext();

                        //foreach(var item in alerts)
                        //{
                        //    //Dapper
                        //    //var dapConnIds = dapperMember.GetListConnectionsByAddress(item.LooserAddress);

                        //    //DbContext
                        //    var users =(from u in db.Members where u.Address.Contains(item.LooserAddress) select u.UserName).ToList();

                        //    IHubContext context = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();
                        //    context.Clients.Users(users).RecieveNotification(item);
                        //}
                        IHubContext context = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();
                        context.Clients.All.RecieveNotification(alerts);

                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }

        }

        void sqlDep_OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info == SqlNotificationInfo.Update)
            {
                var objet = sender as SqlDependency;
                NotificationHub nHub = new NotificationHub();
                nHub.SendNotifications();
            }
        }
    }
}