using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity.Data.Abstract
{
    public class IdentContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public IdentContext(DbContextOptions<IdentContext> options) : base(options)
        {

        }

    }
}