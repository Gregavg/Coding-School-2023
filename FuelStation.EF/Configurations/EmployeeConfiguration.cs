

using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuelStation.EF.Configurations {
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee> {
        public void Configure(EntityTypeBuilder<Employee> builder) {
            // Table Name
            builder.ToTable("Employees");

            // Primary Key
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(t => t.Name).HasMaxLength(50).IsRequired();
            builder.Property(t => t.Surname).HasMaxLength(50).IsRequired();
            builder.Property(t => t.SalaryPerMonth).IsRequired();
            builder.Property(t => t.EmployeeType).IsRequired();
            builder.Property(t => t.HireDateStart).IsRequired();
            builder.Property(t => t.HireDateEnd);



            // Relations
        }
    }
}
