using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nonameClub.Models.Configurations
{
    public class ServerConfiguration : IEntityTypeConfiguration<Servers>
    {
        public void Configure(EntityTypeBuilder<Servers> builder)
        {
            builder
                .HasKey(a => a.ServerId);
            builder
                .Property(m => m.ServerId);
            builder
                .Property(m => m.ServerName)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(m => m.ServerInfo)
                .HasMaxLength(250);
            builder
                .Property(m => m.ServerVersion)
                .HasMaxLength(10);
            builder
                .ToTable("Servers");
        }
    }
}
