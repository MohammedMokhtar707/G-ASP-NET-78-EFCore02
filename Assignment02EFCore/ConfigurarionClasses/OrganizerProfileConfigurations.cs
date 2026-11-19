using Assignment02EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment02EFCore.ConfigurarionClasses;

internal class OrganizerProfileConfigurations : IEntityTypeConfiguration<OrganizerProfile>
{
    public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
    {
        builder.ToTable("OrganizerProfiles");
        builder.HasKey(o => o.OrganizerProfileId);

        builder.Property(o => o.Biography).HasColumnType("VARCHAR")
            .HasMaxLength(200);

        builder.Property(o => o.WebsiteUrl).HasColumnType("VARCHAR")
            .HasMaxLength(100);

        builder.Property(o=>o.LogoUrl).HasColumnType("VARCHAR")
            .HasMaxLength(100);
    }
}
