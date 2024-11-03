using JwtStore.Core.Context.AccountContext.Entities;

namespace JwtStore.Core.Context.AccountContext.UseCases.Create.Contracts
{
    public interface IRepository
    {
        Task<bool> AnyAsync(string email, CancellationToken cancelationToken);
        Task SaveAsync(User user, CancellationToken cancelationToken);
    }
}
