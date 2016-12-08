
using PeopLost.Core.Domain.ConnectionHub;

namespace PeopLost.Data.Mapping.ConnectionHub
{

    public class ConnectionMap:PeopLostEntityTypeConfiguration<Connections>
    {
        public ConnectionMap()
        {
            this.HasKey(t => t.Id);

            this.Property(t => t.Connected);
            this.Property(t => t.MemberId);
            this.Property(t =>t.UserAgent);

        }

    }
}