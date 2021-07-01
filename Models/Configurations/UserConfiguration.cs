using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nonameClub.Models.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder
                .HasKey(a => a.UserId);
            builder
                .Property(m => m.UserId);
            builder
                .Property(m => m.Username)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(m => m.Password)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(m => m.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .HasMany(m => m.Servers)
                .WithOne(a => a.Users)
                .HasForeignKey(m => m.AdminId);
            builder
                .ToTable("Users");
        }
    }
}
