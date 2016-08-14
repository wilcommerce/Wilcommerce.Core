namespace Wilcommerce.Core.Infrastructure
{
    /// <summary>
    /// Represents a generic event bus
    /// </summary>
    public interface IEventBus
    {
        /// <summary>
        /// Raise the specified event
        /// </summary>
        /// <typeparam name="TEvent">The event's type</typeparam>
        /// <param name="event">The event to raise</param>
        void RaiseEvent<TEvent>(TEvent @event) where TEvent : DomainEvent;

        /// <summary>
        /// Register the handler for the event
        /// </summary>
        /// <typeparam name="TEvent">The event's type</typeparam>
        /// <typeparam name="THandler">The handler's type</typeparam>
        void RegisterHandler<TEvent, THandler>() where TEvent : DomainEvent where THandler : IHandleEvent<TEvent>;
    }
}
