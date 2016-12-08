
using PeopLost.Core.Domain.ConnectionHub;
using PeopLost.Core.Domain.Members;
namespace PeopLost.Data.Mapping.Members
{
    public partial class MemberMap:PeopLostEntityTypeConfiguration<Member>
    {
        public MemberMap()
        {
            this.HasKey(t => t.Id);
            this.Property(t => t.Address);
            this.Property(t => t.BirthDay);
            this.Property(t => t.ImageUrl);
            this.Property(t => t.Email);
            this.Property(t => t.UserName);
            this.Property(t => t.Gender).HasMaxLength(1);
            this.Property(t => t.isAdmin);
            this.Property(t => t.Commune);
            //this.Property(t => t.ConnectionId);
           // this.HasRequired(m => m.C)
    //.WithMany()
    //.HasForeignKey(m => m.);


            this.ToTable("Members");
        }
    }
}
