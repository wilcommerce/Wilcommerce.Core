using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wilcommerce.Core.Infrastructure
{
    /// <summary>
    /// Represents a generic command handler
    /// </summary>
    /// <typeparam name="TCommand">The type of the command to handle</typeparam>
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        /// <summary>
        /// Handles the specified command
        /// </summary>
        /// <param name="command">The command to handle</param>
        void Handle(TCommand command);
    }
}
