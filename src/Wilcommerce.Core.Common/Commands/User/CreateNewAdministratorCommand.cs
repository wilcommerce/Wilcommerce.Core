using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Commands.User
{
    public class CreateNewAdministratorCommand : ICommand
    {
        public string Name { get; }

        public string Email { get; }

        public string Password { get; }

        public CreateNewAdministratorCommand(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
