using Assignment02EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment02EFCore.ConfigurarionClasses;

internal class EventConfigurations : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.ToTable("Events");
        builder.HasKey(e => e.EventId);

        builder.Property(e => e.Title).HasColumnType("VARCHAR")
            .HasMaxLength(50);

        builder.Property(e => e.EndDate).IsRequired(false);

    }
}
