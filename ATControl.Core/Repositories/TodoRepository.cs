// --------------------------------------------------------------------------------------------------------------------
// <summary>
//  Defines the TodoRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ATControl.Core.Repositories
{
    /// <summary>
    /// Defines the TodoRepository type.
    /// </summary>
    public class TodoRepository : ITodoRepository
    {
        /// <summary>
        /// Gets or sets the selected item identifier.
        /// </summary>
        public int? SelectedItemId { get; set; }
    }
}
