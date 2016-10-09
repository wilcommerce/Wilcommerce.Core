using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User.Handlers
{
    public class UserEventHandler : 
        IHandleEvent<NewAdministratorCreatedEvent>,
        IHandleEvent<AdministratorNotCreatedEvent>,
        IHandleEvent<UserEmailChangedEvent>,
        IHandleEvent<UserEmailNotChangedEvent>,
        IHandleEvent<UserPasswordChangedEvent>,
        IHandleEvent<UserPasswordNotChangedEvent>,
        IHandleEvent<UserNameChangedEvent>,
        IHandleEvent<UserNameNotChangedEvent>,
        IHandleEvent<UserRoleChangedEvent>,
        IHandleEvent<UserRoleNotChangedEvent>,
        IHandleEvent<UserDisabledEvent>,
        IHandleEvent<UserEnabledEvent>,
        IHandleEvent<UserProfileImageChangedEvent>,
        IHandleEvent<UserProfileImageNotChangedEvent>
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

        public void Handle(AdministratorNotCreatedEvent @event)
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

        public void Handle(UserEmailNotChangedEvent @event)
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

        public void Handle(UserPasswordNotChangedEvent @event)
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

        public void Handle(UserNameNotChangedEvent @event)
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

        public void Handle(UserRoleNotChangedEvent @event)
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

        public void Handle(UserProfileImageNotChangedEvent @event)
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
