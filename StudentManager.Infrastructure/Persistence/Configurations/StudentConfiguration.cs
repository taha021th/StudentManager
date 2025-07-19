using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Infrastructure.Persistence.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.FullName).HasMaxLength(200).IsRequired();
            builder.Property(s => s.NationalCode).HasMaxLength(10).IsRequired();
            builder.HasIndex(s => s.NationalCode).IsUnique();

            builder.Property(s => s.BirthDate).IsRequired();
        }
    }
}
