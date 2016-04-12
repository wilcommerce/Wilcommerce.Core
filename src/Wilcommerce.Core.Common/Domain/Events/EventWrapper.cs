using Newtonsoft.Json;
using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Domain.Events
{
    public class EventWrapper
    {
        #region Properties
        /// <summary>
        /// Get or set the Id of the wrapper
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Get or set the timestamp of the wrapper
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Get or set the type of the event
        /// </summary>
        public Type EventType { get; set; }

        /// <summary>
        /// Get or set the serialized event
        /// </summary>
        public string EventBody { get; set; }

        /// <summary>
        /// Get the deserialized event data
        /// </summary>
        public dynamic EventData
        {
            get
            {
                var settings = new JsonSerializerSettings();
                settings.TypeNameHandling = TypeNameHandling.Objects;

                var @event = JsonConvert.DeserializeObject(this.EventBody, this.EventType, settings);
                return (dynamic)(@event as DomainEvent);
            }
        }
        #endregion

        #region Constructor
        protected EventWrapper() { }
        #endregion

        #region Static Methods
        /// <summary>
        /// Wrap the specified event
        /// </summary>
        /// <typeparam name="TEvent">The event's type</typeparam>
        /// <param name="event">The event to wrap</param>
        /// <returns>The created event wrapper</returns>
        public static EventWrapper Wrap<TEvent>(TEvent @event) where TEvent : DomainEvent
        {
            if(@event == null)
            {
                throw new ArgumentNullException("event");
            }

            var eventWrapper = new EventWrapper
            {
                Id = Guid.NewGuid(),
                Timestamp = DateTime.Now,
                EventType = typeof(TEvent),
                EventBody = JsonConvert.SerializeObject(@event)
            };

            return eventWrapper;
        }
        #endregion
    }
}
