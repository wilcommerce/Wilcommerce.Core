using System;
using System.Collections.Generic;

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

        /// <summary>
        /// Find all the events of the specified type
        /// </summary>
        /// <typeparam name="TEvent">The event's type to search for</typeparam>
        /// <param name="timestamp">The timestamp by which filters the event's list</param>
        /// <returns>A list of events</returns>
        IEnumerable<TEvent> Find<TEvent>(DateTime timestamp) where TEvent : DomainEvent;

        /// <summary>
        /// Find all the events of the specified type
        /// </summary>
        /// <typeparam name="TEvent">The event's type to search for</typeparam>
        /// <param name="entityType">The entity type which fired the events</param>
        /// <param name="timestamp">The timestamp by which filters the event's list</param>
        /// <returns>A list of events</returns>
        IEnumerable<TEvent> Find<TEvent>(string entityType, DateTime timestamp) where TEvent : DomainEvent;

        /// <summary>
        /// Find all the events of the specified type
        /// </summary>
        /// <typeparam name="TEvent">The event's type to search for</typeparam>
        /// <param name="entityType">The entity type which fired the events</param>
        /// <param name="entityId">The id of the entity which fired the events</param>
        /// <param name="timestamp">The timestamp by which filters the event's list</param>
        /// <returns>A list of events</returns>
        IEnumerable<TEvent> Find<TEvent>(string entityType, Guid entityId, DateTime timestamp) where TEvent : DomainEvent;

        /// <summary>
        /// Find all the occured events for the specified entity
        /// </summary>
        /// <param name="entityType">The entity type which fired the events</param>
        /// <param name="entityId">The id of the entity which fired the events</param>
        /// <param name="timestamp">The timestamp by which filters the event's list</param>
        /// <returns>The list of occured events</returns>
        IEnumerable<DomainEvent> FindAll(string entityType, Guid entityId, DateTime timestamp);
    }
}
