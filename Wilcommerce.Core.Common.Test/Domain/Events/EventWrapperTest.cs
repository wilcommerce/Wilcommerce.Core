using Xunit;
using Wilcommerce.Core.Common.Domain.Events;
using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Test.Domain.Events
{
    public class EventWrapperTest
    {
        public class FakeEvent : DomainEvent
        {
            public string Value { get; private set; }

            public FakeEvent(string value)
                : base()
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
                : base()
            {

            }
        }

        [Fact]
        public void EventWrapper_Should_Throw_ArgumentNullException_If_Event_IsNull()
        {
            DomainEvent ev = null;
            var ex = Assert.Throws<ArgumentNullException>(() => EventWrapper.Wrap(ev));

            Assert.Equal("event", ex.ParamName);
        }

        [Fact]
        public void EventWrapper_GetEventData_Should_Throw_ArgumentException_If_EventType_IsNot_The_Same()
        {
            var ev = new FakeEvent("value");
            var wrapper = EventWrapper.Wrap(ev);

            var ex = Assert.Throws<ArgumentException>(() => wrapper.GetEventData(typeof(AnotherEvent)));
            Assert.Equal("The type does not correspond to the saved type", ex.Message);
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
