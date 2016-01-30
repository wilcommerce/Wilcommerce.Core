namespace Wilcommerce.Core.Infrastructure
{
    /// <summary>
    /// Defines the contract for the event handlers
    /// </summary>
    /// <typeparam name="TEvent">The event's type</typeparam>
    public interface IHandleEvent<TEvent> where TEvent : DomainEvent
    {
        /// <summary>
        /// Handles the specified event
        /// </summary>
        /// <param name="event">The event to handle</param>
        void Handle(TEvent @event);
    }
}
