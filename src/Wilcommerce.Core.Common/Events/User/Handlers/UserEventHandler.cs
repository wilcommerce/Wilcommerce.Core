using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User.Handlers
{
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
        public IEventStore EventStore { get; }

        public UserEventHandler(IEventStore eventStore)
        {
            EventStore = eventStore;
        }

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
