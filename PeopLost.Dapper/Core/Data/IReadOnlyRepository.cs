using PeopLost.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PeopLost.Dapper.Core.Data
{
    interface IReadOnlyRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// The find by id.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        T FindById(Guid id);

        /// <summary>
        /// The get all.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/> of T.
        /// </returns>
        IEnumerable<T> GetAll();
    }
}
