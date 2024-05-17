using Microsoft.AspNetCore.Identity;

namespace ShoppingCart.Repository
{
    public interface ITokenRepository
    {
        string GenerateTokenAsync(IdentityUser user,List<string> Roles);
    }
}
