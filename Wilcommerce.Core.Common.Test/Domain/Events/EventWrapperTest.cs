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

        [Fact]
        public void EventWrapper_Should_Throw_ArgumentNullException_If_Event_IsNull()
        {
            DomainEvent ev = null;
            var ex = Assert.Throws<ArgumentNullException>(() => EventWrapper.Wrap(ev));

            Assert.Equal("event", ex.ParamName);
        }

        [Fact]
        public void EventWrapper_Should_Deserialize_FakeEvent()
        {
            var ev = new FakeEvent("value");
            var wrapper = EventWrapper.Wrap(ev);

            var deserialized = wrapper.EventData;

            Assert.Equal(typeof(FakeEvent), deserialized.GetType());
            Assert.Equal(ev.ToString(), deserialized.ToString());
        }
    }
}
