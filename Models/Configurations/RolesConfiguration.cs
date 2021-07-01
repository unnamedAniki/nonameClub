using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nonameClub.Models.Configurations
{
    public class RolesConfiguration : IEntityTypeConfiguration<Roles>
    {
        public void Configure(EntityTypeBuilder<Roles> builder)
        {
            builder
                .HasKey(a => a.RoleId);
            builder
                .Property(m => m.RoleId);
            builder
                .Property(m => m.RolePriority);
            builder
                .Property(m => m.RoleName)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .HasMany(m => m.Users)
                .WithOne(a => a.Roles)
                .HasForeignKey(m => m.UserId);
            builder
                .ToTable("Roles");
        }
    }
}
