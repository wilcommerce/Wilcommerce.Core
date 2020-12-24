using System;

namespace Wilcommerce.Core.Infrastructure
{
    /// <summary>
    /// Represents a generic event
    /// </summary>
    public abstract class DomainEvent
    {
        /// <summary>
        /// Get the date and time of when the event is fired
        /// </summary>
        public DateTime FiredOn { get; private set; }

        /// <summary>
        /// Get the id of the aggregate which generate the event
        /// </summary>
        public Guid AggregateId { get; private set; }

        /// <summary>
        /// Get the type of the aggregate which generate the event
        /// </summary>
        public Type AggregateType { get; private set; }

        /// <summary>
        /// Get the ID of the user which raised the event
        /// </summary>
        public string UserId { get; private set; }

        /// <summary>
        /// Construct the domain event
        /// </summary>
        /// <param name="aggregateId"></param>
        /// <param name="aggregateType"></param>
        /// <param name="userId"></param>
        public DomainEvent(Guid aggregateId, Type aggregateType, string userId)
        {
            AggregateId = aggregateId;
            AggregateType = aggregateType;
            UserId = userId;
            FiredOn = DateTime.Now;
        }
    }
}
