

using PeopLost.Core.Domain.Alertes;
namespace PeopLost.Data.Mapping.Alertes
{
    public partial class AlertMap : PeopLostEntityTypeConfiguration<Alert>
    {
        public AlertMap()
        {
            this.HasKey(t => t.Id);

            this.Property(t => t.Post);

            this.HasRequired(t => t.Person)
                .WithMany()
                .HasForeignKey(t=>t.PersonId);

            this.Property(t => t.LooserAddress).HasMaxLength(200);
            this.Property(t => t.DateAlert).HasColumnType("datetime2");

            this.Property(t => t.DateValidation).HasColumnType("date");

            this.HasRequired(m => m.Member)
                .WithMany()
                .HasForeignKey(m => m.UserId);

            this.Property(m => m.ConcreteAlert);
            this.Property(m => m.Found).IsOptional();
            this.Property(m => m.DayDisappear);

        }
    }
}