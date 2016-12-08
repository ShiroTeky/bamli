using PeopLost.Core.Domain.Countries;

namespace PeopLost.Data.Mapping.Countries
{
    public partial class CountryMap:PeopLostEntityTypeConfiguration<Country>
    {
        
        public CountryMap()
        {
            this.HasKey(t => t.Id);
            this.Property(t => t.CountryID);
            this.Property(t => t.Name);
            this.ToTable("Countries");
        }

        
    }
}
