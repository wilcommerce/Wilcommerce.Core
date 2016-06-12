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
        public string EventType { get; set; }

        /// <summary>
        /// Get or set the serialized event
        /// </summary>
        public string EventBody { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Get the deserialized event, based on the specified type
        /// </summary>
        /// <param name="eventType">The type of the event to deserialize</param>
        /// <returns>The deserialized event</returns>
        public dynamic GetEventData(Type eventType)
        {
            if(eventType.ToString() != EventType)
            {
                throw new ArgumentException("The type does not correspond to the saved type");
            }

            var settings = new JsonSerializerSettings();
            settings.TypeNameHandling = TypeNameHandling.Objects;

            var @event = JsonConvert.DeserializeObject(EventBody, eventType, settings);
            return (dynamic)(@event as DomainEvent);
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
                EventType = typeof(TEvent).ToString(),
                EventBody = JsonConvert.SerializeObject(@event)
            };

            return eventWrapper;
        }
        #endregion
    }
}
