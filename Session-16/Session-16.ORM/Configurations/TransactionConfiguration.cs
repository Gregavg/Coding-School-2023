
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_16.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.ORM.Configurations {
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction> {


        public void Configure(EntityTypeBuilder<Transaction> builder) {
            builder.ToTable("Transaction");

            builder.HasKey(transaction => transaction.ID);
            builder.Property(transaction => transaction.ID).HasMaxLength(100).IsRequired(true);

            builder.Property(transaction => transaction.Date).HasMaxLength(100);
            builder.Property(transaction => transaction.CustomerID).HasMaxLength(100);
            builder.Property(transaction => transaction.EmployeeID).HasMaxLength(100);
            builder.Property(transaction => transaction.PetID).HasMaxLength(50);
            builder.Property(transaction => transaction.PetFoodID).HasMaxLength(50);

            builder.Property(transaction => transaction.PetPrice).HasPrecision(20, 2);
            builder.Property(transaction => transaction.PetFoodQty).HasPrecision(20, 2);
            builder.Property(transaction => transaction.PetFoodPrice).HasPrecision(20,2);
            builder.Property(transaction => transaction.TotalPrice).HasPrecision(20,2);



            //foreign Pet
            builder.HasOne(transaction => transaction.pet)
                .WithOne(pet => pet.transaction)
                .HasForeignKey<Transaction>(transaction => transaction.PetID);

            //foreign Customer
            builder.HasOne(transaction => transaction.customer)
                .WithMany(customer => customer.Transactions)
                .HasForeignKey(transaction => transaction.CustomerID);

            //foreign Employee
            builder.HasOne(transaction => transaction.employee)
                .WithMany(employee => employee.Transactions)
                .HasForeignKey(transaction => transaction.EmployeeID);

            //foreign key PetFood
            builder.HasOne(transaction => transaction.petFood)
                    .WithMany(petfood => petfood.Transactions)
                    .HasForeignKey(transaction => transaction.PetFoodID);
        }

    }
}
