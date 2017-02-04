using System;

namespace Wilcommerce.Core.Infrastructure
{
    /// <summary>
    /// Represents a generic event
    /// </summary>
    public abstract class DomainEvent
    {
        /// <summary>
        /// The date and time of when the event is fired
        /// </summary>
        public DateTime FiredOn { get; }

        /// <summary>
        /// The id of the aggregate which generate the event
        /// </summary>
        public Guid AggregateId { get; }

        /// <summary>
        /// The type of the aggregate which generate the event
        /// </summary>
        public Type AggregateType { get; }

        public DomainEvent(Guid aggregateId, Type aggregateType)
        {
            AggregateId = aggregateId;
            AggregateType = aggregateType;
            FiredOn = DateTime.Now;
        }
    }
}
