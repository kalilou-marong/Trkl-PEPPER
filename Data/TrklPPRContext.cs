using TrklPPR.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TrklPPR.Data
{
    public class TrklPPRContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Category> Categories { get; set; } = default!;
        public DbSet<Employee> Employees { get; set; } = default!;
        public DbSet<Review> Reviews { get; set; } = default!;
        public DbSet<Dish> Dishes { get; set; } = default!;
        public DbSet<Drink> Drinks { get; set; } = default!;
        public DbSet<Discover> Discovers { get; set; } = default!;
        public DbSet<ReservationForm> Reservations { get; set; } = default!;

        public TrklPPRContext(DbContextOptions<TrklPPRContext> options) : base(options)
        {

        }

    }
}
