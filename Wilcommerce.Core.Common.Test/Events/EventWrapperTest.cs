using Xunit;
using Wilcommerce.Core.Common.Events;
using System;
using Wilcommerce.Core.Infrastructure;
using Newtonsoft.Json;

namespace Wilcommerce.Core.Common.Test.Events
{
    public class EventWrapperTest
    {
        public class FakeEvent : DomainEvent
        {
            public string Value { get; private set; }

            public FakeEvent(string value)
                : base(Guid.NewGuid(), typeof(IAggregateRoot))
            {
                this.Value = value;
            }

            public override string ToString()
            {
                return $"{this.FiredOn.ToString("yyyy-MM-dd HH:mm")} - {this.Value}";
            }
        }

        [Fact]
        public void EventWrapper_Should_Throw_ArgumentNullException_If_Event_IsNull()
        {
            DomainEvent @event = null;
            var ex = Assert.Throws<ArgumentNullException>(() => EventWrapper.Wrap(@event));

            Assert.Equal(nameof(@event), ex.ParamName);
        }

        [Fact]
        public void EventWrapper_Should_Wrap_The_Specified_Event()
        {
            var @event = new FakeEvent("value");
            var wrapper = EventWrapper.Wrap(@event);

            Assert.Equal(@event.AggregateId, wrapper.AggregateId);
            Assert.Equal(@event.AggregateType.ToString(), wrapper.AggregateType);
            Assert.Equal($"{@event.GetType().FullName}, {@event.GetType().Assembly.GetName().Name}", wrapper.EventType);
            Assert.Equal(JsonConvert.SerializeObject(@event), wrapper.EventBody);
        }

        [Fact]
        public void EventWrapper_Should_Deserialize_FakeEvent()
        {
            var ev = new FakeEvent("value");
            var wrapper = EventWrapper.Wrap(ev);

            var deserialized = wrapper.Event;

            Assert.Equal(typeof(FakeEvent), deserialized.GetType());
            Assert.Equal(ev.ToString(), deserialized.ToString());
        }
    }
}
