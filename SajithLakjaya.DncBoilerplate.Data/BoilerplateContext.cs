using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SajithLakjaya.DncBoilerplate.Core.Domain.Identity;

namespace SajithLakjaya.DncBoilerplate.Data
{
    public class BoilerplateContext : IdentityDbContext<User, Role, long>
    {
        public BoilerplateContext(DbContextOptions<BoilerplateContext> options) : base(options)
        {
        }
    }
}
