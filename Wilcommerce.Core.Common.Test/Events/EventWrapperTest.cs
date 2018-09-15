using Xunit;
using Wilcommerce.Core.Common.Events;
using System;
using Wilcommerce.Core.Infrastructure;

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

        public class AnotherEvent : DomainEvent
        {
            public AnotherEvent()
                : base(Guid.NewGuid(), typeof(IAggregateRoot))
            {

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
        public void EventWrapper_GetEventData_Should_Throw_ArgumentException_If_EventType_IsNot_The_Same()
        {
            var ev = new FakeEvent("value");
            var wrapper = EventWrapper.Wrap(ev);

            var ex = Assert.Throws<ArgumentException>(() => wrapper.GetEventData(typeof(AnotherEvent)));
            Assert.Equal("eventType", ex.ParamName);
        }

        [Fact]
        public void EventWrapper_Should_Deserialize_FakeEvent()
        {
            var ev = new FakeEvent("value");
            var wrapper = EventWrapper.Wrap(ev);

            var deserialized = wrapper.GetEventData(Type.GetType(wrapper.EventType));

            Assert.Equal(typeof(FakeEvent), deserialized.GetType());
            Assert.Equal(ev.ToString(), deserialized.ToString());
        }
    }
}
