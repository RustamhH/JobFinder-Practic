using Database.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Configurations
{
    public class JobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {

            // Set primary key
            builder.HasKey(j => j.Id);

            // Configure properties
            builder.Property(j => j.Title).IsRequired().HasMaxLength(100);
            builder.Property(j => j.StateType).HasMaxLength(50);
            builder.Property(j => j.WorkingSchedule).HasMaxLength(50);
            builder.Property(j => j.StandartEntranceProccess).HasMaxLength(100);
            builder.Property(j => j.Category).HasMaxLength(50);
            builder.Property(j => j.Description).IsRequired().HasMaxLength(500);
            builder.Property(j => j.VacancyCode).HasMaxLength(20);
            builder.Property(j => j.VacancyUrl).HasMaxLength(200);
            builder.Property(j => j.ProfileRequierments).HasMaxLength(500);
            builder.Property(j => j.ExpireDateTime).IsRequired();
            builder.Property(j => j.AppUserId).IsRequired();

            builder.HasOne(j => j.AppUser)
                   .WithMany()
                   .HasForeignKey(j => j.AppUserId)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
