
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_16.Model;
using System;
using System.Linq;

namespace Session_16.ORM.Configurations {
    public class PetConfiguration : IEntityTypeConfiguration<Pet> {


        public void Configure(EntityTypeBuilder<Pet> builder) {
            builder.ToTable("Pet");

            builder.HasKey(pet => pet.ID);
            builder.Property(pet => pet.ID).HasMaxLength(100).IsRequired(true);

            builder.Property(pet => pet.TransactionID).HasMaxLength(100);
            builder.Property(pet => pet.Animaltype).HasMaxLength(50);
            builder.Property(pet => pet.Petstatus).HasMaxLength(50);
            builder.Property(pet => pet.Breed).HasMaxLength(50);

            builder.Property(pet => pet.Price).HasPrecision(20, 2);
            builder.Property(pet => pet.Cost).HasPrecision(20, 2);

            builder.Property(pet => pet.Bought).HasMaxLength(25);

            //foreign Pet
            builder.HasOne(pet => pet.transaction)
                .WithOne(transaction => transaction.pet)
                .HasForeignKey<Pet>(pet => pet.TransactionID);


        }

    }
}
