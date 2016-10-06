﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wilcommerce.Core.Common.Domain.Repository;

namespace Wilcommerce.Core.Common.Commands.User.Handlers
{
    public class ChangeUserPasswordCommandHandler : Interfaces.IChangeUserPasswordCommandHandler
    {
        public IRepository Repository { get; }

        public ChangeUserPasswordCommandHandler(IRepository repository)
        {
            Repository = repository;
        }

        public async Task Handle(ChangeUserPasswordCommand command)
        {
            try
            {
                var user = await Repository.GetByKeyAsync<Domain.Models.User>(command.UserId);
                user.ChangePassword(command.Password);

                await Repository.SaveChangesAsync();
            }
            catch 
            {
                throw;
            }
        }
    }
}
