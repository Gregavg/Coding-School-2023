

using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuelStation.EF.Configurations {
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer> {
        public void Configure(EntityTypeBuilder<Customer> builder) {
            // Table Name
            builder.ToTable("Customers");

            // Primary Key
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(t => t.CardNumber).HasMaxLength(100).IsRequired();
            builder.HasIndex(t => t.CardNumber).IsUnique();

            builder.Property(t => t.Name).HasMaxLength(50).IsRequired();
            builder.Property(t => t.Surname).HasMaxLength(50).IsRequired();

            // 
            builder.HasIndex(t => t.CardNumber).IsUnique();
        }
    }
}
