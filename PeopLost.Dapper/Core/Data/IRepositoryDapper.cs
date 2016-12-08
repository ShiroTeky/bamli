using PeopLost.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopLost.Dapper.Core.Data
{
    interface IRepositoryDapper<T>: IReadOnlyRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        void Add(T item);

        /// <summary>
        /// Removes the specified item.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        void Remove(T item);

        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        void Update(T item);

        /// <summary>
        /// Deletes the record by the ID
        /// </summary>
        /// <param name="id">
        /// The unique ID
        /// </param>
        void Delete(int id);
    }
}
