using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User.Handlers
{
    /// <summary>
    /// Handles all the events related to the user
    /// </summary>
    public class UserEventHandler : 
        IHandleEvent<NewAdministratorCreatedEvent>,
        IHandleEvent<UserEmailChangedEvent>,
        IHandleEvent<UserPasswordChangedEvent>,
        IHandleEvent<UserNameChangedEvent>,
        IHandleEvent<UserRoleChangedEvent>,
        IHandleEvent<UserDisabledEvent>,
        IHandleEvent<UserEnabledEvent>,
        IHandleEvent<UserProfileImageChangedEvent>
    {
        /// <summary>
        /// Get the event store instance
        /// </summary>
        public IEventStore EventStore { get; }

        /// <summary>
        /// Construct the event handler
        /// </summary>
        /// <param name="eventStore"></param>
        public UserEventHandler(IEventStore eventStore)
        {
            EventStore = eventStore;
        }

        /// <see cref="Infrastructure.IHandleEvent{TEvent}"/>
        public void Handle(NewAdministratorCreatedEvent @event)
        {
            try
            {
                EventStore.Save(@event);
            }
            catch 
            {
                throw;
            }
        }

        /// <see cref="Infrastructure.IHandleEvent{TEvent}"/>
        public void Handle(UserEmailChangedEvent @event)
        {
            try
            {
                EventStore.Save(@event);
            }
            catch
            {
                throw;
            }
        }

        /// <see cref="Infrastructure.IHandleEvent{TEvent}"/>
        public void Handle(UserPasswordChangedEvent @event)
        {
            try
            {
                EventStore.Save(@event);
            }
            catch
            {
                throw;
            }
        }

        /// <see cref="Infrastructure.IHandleEvent{TEvent}"/>
        public void Handle(UserNameChangedEvent @event)
        {
            try
            {
                EventStore.Save(@event);
            }
            catch
            {
                throw;
            }
        }

        /// <see cref="Infrastructure.IHandleEvent{TEvent}"/>
        public void Handle(UserRoleChangedEvent @event)
        {
            try
            {
                EventStore.Save(@event);
            }
            catch
            {
                throw;
            }
        }

        /// <see cref="Infrastructure.IHandleEvent{TEvent}"/>
        public void Handle(UserDisabledEvent @event)
        {
            try
            {
                EventStore.Save(@event);
            }
            catch
            {
                throw;
            }
        }

        /// <see cref="Infrastructure.IHandleEvent{TEvent}"/>
        public void Handle(UserEnabledEvent @event)
        {
            try
            {
                EventStore.Save(@event);
            }
            catch
            {
                throw;
            }
        }

        /// <see cref="Infrastructure.IHandleEvent{TEvent}"/>
        public void Handle(UserProfileImageChangedEvent @event)
        {
            try
            {
                EventStore.Save(@event);
            }
            catch
            {
                throw;
            }
        }
    }
}
