namespace Wilcommerce.Core.Infrastructure
{
    /// <summary>
    /// Represents a generic event store
    /// </summary>
    public interface IEventStore
    {
        /// <summary>
        /// Saves the specified event
        /// </summary>
        /// <typeparam name="TEvent">The type of the event to save</typeparam>
        /// <param name="event">The event to save</param>
        void Save<TEvent>(TEvent @event) where TEvent : DomainEvent;
    }
}
