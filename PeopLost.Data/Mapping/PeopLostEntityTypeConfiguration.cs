using PeopLost.Core;
using System.Data.Entity.ModelConfiguration;

namespace PeopLost.Data.Mapping
{
    public abstract class PeopLostEntityTypeConfiguration<T>:EntityTypeConfiguration<T> where T:BaseEntity
    {
        protected  PeopLostEntityTypeConfiguration()
        {
            PostInitialize();
        }

        /// <summary>
        /// Developers can override this method in custom partial classes
        /// in order to add some custom initialization code to constructors
        /// </summary>
        protected virtual void PostInitialize()
        {
            
        }
    }
}
