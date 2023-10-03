using Jazani.Domain.Admins.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jazani.Infrastructure.Admins.Configurations
{
    public class AlertConfiguration : IEntityTypeConfiguration<Alertt>
    {
        public void Configure(EntityTypeBuilder<Alertt> builder)
        {
            builder.ToTable("alert", "ge");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).HasColumnName("name");
            builder.Property(t => t.Description).HasColumnName("description");
            builder.Property(t => t.StartDate).HasColumnName("startdate");
            builder.Property(t => t.EndDate).HasColumnName("enddate");
            builder.Property(t => t.RuletypeId).HasColumnName("ruletypeid");
            builder.Property(t => t.RegistrationDate).HasColumnName("registrationdate");
            builder.Property(t => t.State).HasColumnName("state");
           


        }
    }
}

