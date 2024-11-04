﻿using JwtStore.Core.Contexts.AccountContext.Entities;

namespace JwtStore.Core.Contexts.AccountContext.UseCases.Authenticate.Contracts
{
    public interface IRepository
    {
        Task<User?> GetUserByEmailAsync(string requestEmail, CancellationToken cancellationToken);
    }
}
