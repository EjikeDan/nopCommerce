namespace Nop.Core.Domain
{
    /// <summary>
    /// Represents a database item which won't be deleted exactly  
    /// </summary>
    public partial interface INotDeletedEntity
    {
        /// <summary>
        /// Gets or sets a value indicating whether the entity has been deleted
        /// </summary>
        bool Deleted { get; set; }
    }
}
