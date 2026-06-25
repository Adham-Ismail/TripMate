using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TripMate.DAL.Models;

namespace TripMate.DAL.Contexts
{
    public partial class TripMateContext : IdentityDbContext<User>
    {
        public TripMateContext(DbContextOptions<TripMateContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Your custom configurations go here later
        }
    }
}
