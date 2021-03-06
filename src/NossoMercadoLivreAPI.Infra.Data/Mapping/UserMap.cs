﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NossoMercadoLivreAPI.Domain.Entities;

namespace NossoMercadoLivreAPI.Infra.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("user");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("id").ValueGeneratedOnAdd().IsRequired();
            builder.Property(c => c.Email).HasColumnName("email").HasMaxLength(100).IsRequired();
            builder.HasIndex(c => c.Email).IsUnique();
            builder.Property(c => c.Password).HasColumnName("password_hash").HasMaxLength(100).IsRequired();
        }
    }
}
