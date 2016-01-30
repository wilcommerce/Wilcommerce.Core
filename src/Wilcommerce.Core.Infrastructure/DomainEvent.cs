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
        public DateTime FiredOn { get; private set; }

        public DomainEvent()
        {
            this.FiredOn = DateTime.Now;
        }
    }
}
