using JwtStore.Core.Contexts.AccountContext.Entities;
using JwtStore.Core.Contexts.AccountContext.UseCases.Create.Contracts;
using JwtStore.Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace JwtStore.Infra.Contexts.AccountContext.UseCases.Create
{
    public class Repository : IRepository
    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public async Task<bool> AnyAsync(string email, CancellationToken cancelationToken)
       => await _context
            .Users
            .AsNoTracking()
            .AnyAsync(x => x.Email == email, cancelationToken);

        public async Task SaveAsync(User user, CancellationToken cancelationToken)
        {
            await _context.Users.AddAsync(user, cancelationToken);
            await _context.SaveChangesAsync(cancelationToken);
        }
    }
}
