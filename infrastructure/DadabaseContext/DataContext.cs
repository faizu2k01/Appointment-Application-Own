using infrastructure.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.DadabaseContext
{ 
    public  class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

       public DbSet<AppUser> users { get; set; }

       public DbSet<AppointmentWith> appointmentWiths { get; set; }

       public DbSet<Professional> professionals { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

          builder.Entity<AppUser>()
                .HasMany(x => x.AppointmentWiths)
                .WithOne(y => y.User)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
