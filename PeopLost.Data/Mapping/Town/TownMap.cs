using PeopLost.Core.Domain.Towns;
using PeopLost.Core.Domain.Countries;

namespace PeopLost.Data.Mapping.Towns
{
    public partial class TownMap:PeopLostEntityTypeConfiguration<Town>
    {
        
        public TownMap()
        {
            this.HasKey(t => t.Id);
            this.Property(t => t.TownID);
            this.HasRequired(t => t.Country)
            .WithMany()
            .HasForeignKey(t => t.CountryID);
            this.Property(t => t.Name);
            this.ToTable("Towns");
        }

        
    }
}
