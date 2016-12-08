using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopLost.Dapper.Core.Data
{
    /// <summary>
    /// The aggregate root for use in the repository.
    /// </summary>
    /// <remarks>
    /// This indicates what objects can be directly loaded from the repository.
    /// </remarks>
    public interface IAggregateRoot
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        int ID { get; set; }
    }
}