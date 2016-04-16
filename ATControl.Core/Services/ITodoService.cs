// --------------------------------------------------------------------------------------------------------------------
// <summary>
//  Defines the ITodoService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ATControl.Core.Services
{
    using Entities;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the ITodoService type.
    /// </summary>
    public interface ITodoService
    {
        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <returns></returns>
        IEnumerable<TodoItem> GetItems();

        /// <summary>
        /// Gets the items not done.
        /// </summary>
        /// <returns></returns>
        IEnumerable<TodoItem> GetItemsNotDone();

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        TodoItem GetItem(int id);

        /// <summary>
        /// Saves the item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        int SaveItem(TodoItem item);

        /// <summary>
        /// Deletes the item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        int DeleteItem(int id);
    }
}