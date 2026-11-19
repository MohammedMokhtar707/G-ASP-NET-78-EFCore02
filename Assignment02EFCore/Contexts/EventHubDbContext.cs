using Assignment02EFCore.ConfigurarionClasses;
using Assignment02EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment02EFCore.Contexts;
internal class EventHubDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //ConnectionString
        optionsBuilder.UseSqlServer("Server=.;Database=EventHub;Trusted_Connection=True;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //FluentAPI direct inside the OnModelCreating method
        modelBuilder.Entity<Badge>(builder =>
        {
            builder.ToTable("Badges");

            builder.HasKey(b => b.BadgeId);

            builder.Property(b => b.Tier)
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);
        });
        //FluentAPI using separateConfigurationClasses
        modelBuilder.ApplyConfiguration<Event>(new EventConfigurations());
        modelBuilder.ApplyConfiguration<OrganizerProfile>(new OrganizerProfileConfigurations());
    }

    public DbSet<Organizer> Organizers { get; set; }
    public DbSet<Attendee> Attendees { get; set; }

}
