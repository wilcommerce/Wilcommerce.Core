using System.Threading.Tasks;

namespace Wilcommerce.Core.Infrastructure
{
    /// <summary>
    /// Represents a generic command handler which handles the command using the async/await pattern
    /// </summary>
    /// <typeparam name="TCommand">The type of the command to handle</typeparam>
    public interface ICommandHandlerAsync<TCommand> where TCommand : ICommand
    {
        /// <summary>
        /// Async method. Handles the specified command
        /// </summary>
        /// <param name="command">The command to handle</param>
        /// <returns></returns>
        Task Handle(TCommand command);
    }
}
