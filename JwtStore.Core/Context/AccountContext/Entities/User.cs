using JwtStore.Core.Context.AccountContext.ValueObjects;
using JwtStore.Core.Context.SharedContext.Entities;

namespace JwtStore.Core.Context.AccountContext.Entities
{
    public class User : Entity
    {
        public string Name { get; private set; }
        public Email Email { get; private set; }
    }
}
