# Wilcommerce - Core
Wilcommerce Core is the infrastructure project for Wilcommerce.
It contains a list of projects which composes the core of the project.

## Wilcommerce.Core.Infrastructure
Wilcommerce.Core.Infrastructure is the infrastructure project for Wilcommerce.
It contains a list of classes and interfaces used for the infrastructure layer for this project.

### Installation
NuGet package is available here [https://www.nuget.org/packages/Wilcommerce.Core.Infrastructure](https://www.nuget.org/packages/Wilcommerce.Core.Infrastructure)

### Elements
- **IAggregateRoot** is the interface which represents an Aggregate root.
- **ICommand** is the interface which represents a generic command.
- **ICommandHandler**, a generic interface which represents a generic command handler and expose the Handle method for the command.
- **ICommandHandlerAsync**, a generic interface which represents a generic command handler and expose the Handle method as async method.
- **IRepository** is the interface which exposes all the methods to manage the persistence of an aggregate root.
- **DomainEvent** is an abstract class which represents a generic domain event.
- **IHandleEvent** is a generic interface which represents an event handler and exposes the Handle method.
- **IEventStore** is the interface which represents a generic event store and exposes methods to persist and retrieves events.

## Wilcommerce.Core.Common
Contains all the components which are commons to all the other packages.

### Installation
NuGet package available here [https://www.nuget.org/packages/Wilcommerce.Core.Common](https://www.nuget.org/packages/Wilcommerce.Core.Common)

### Domain
The Domain namespace defines all the models and the components to manage them.

### Commands
The Commands namespace contains all the actions available for this package.

### Events
The Events namespace contains all the events that could happen.

# Contributing
If you want to contribute to Wilcommerce please, check the [CONTRIBUTING](CONTRIBUTING.md) file.