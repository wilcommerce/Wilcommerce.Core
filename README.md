# Wilcommerce - Core
Wilcommerce Core is the infrastructure project for Wilcommerce.
It contains a list of projects which composes the core of the project.

## Wilcommerce.Core.Infrastructure
Wilcommerce.Core.Infrastructure is the infrastructure project for Wilcommerce.
It contains a list of classes and interfaces used for the infrastructure layer for this project.

The latest version of the nuget package is available here https://www.nuget.org/packages/Wilcommerce.Core.Infrastructure/

The elements of this project are:
- **IAggregateRoot** is the interface which represents an Aggregate root.
- **ICommand** is the interface which represents a generic command.
- **ICommandHandler**, a generic interface which represents a generic command handler and expose the Handle method for the command.
- **ICommandHandlerAsync**, a generic interface which represents a generic command handler and expose the Handle method as async method.
- **IRepository** is the interface which exposes all the methods to manage the persistence of an aggregate root.
- **DomainEvent** is an abstract class which represents a generic domain event.
- **IHandleEvent** is a generic interface which represents an event handler and exposes the Handle method.
- **IEventStore** is the interface which represents a generic event store and exposes a Save method to persist a Domain event.
