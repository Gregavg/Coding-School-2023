
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_16.Model;
using System;
using System.Linq;

namespace Session_16.ORM.Configurations {
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer> {


        public void Configure(EntityTypeBuilder<Customer> builder) {
            builder.ToTable("Customer");

            builder.HasKey(customer => customer.ID);
            builder.Property(customer => customer.ID).HasMaxLength(100).IsRequired(true);
            builder.Property(customer => customer.Name).HasMaxLength(50);
            builder.Property(customer => customer.Surname).HasMaxLength(50);
            builder.Property(customer => customer.Phone).HasMaxLength(30);
            builder.Property(customer => customer.TIN).HasPrecision(20, 2);


        }

    }
}
