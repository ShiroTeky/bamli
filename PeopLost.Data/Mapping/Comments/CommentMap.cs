

using PeopLost.Core.Domain.Comments;
namespace PeopLost.Data.Mapping.Comments
{
    public partial class CommentMap: PeopLostEntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            this.HasKey(t => t.Id);

            this.Property(t => t.Post);

            this.Property(t => t.DatePost).HasColumnType("datetime2");

            this.HasRequired(t => t.Member).WithMany()
                .HasForeignKey(t=>t.MemberId)
                .WillCascadeOnDelete(false);

            this.HasRequired(m => m.Alert).WithMany()
                .HasForeignKey(t=>t.AlertId)
                .WillCascadeOnDelete(false);
            this.ToTable("Comments");
        }

        
    }
}
