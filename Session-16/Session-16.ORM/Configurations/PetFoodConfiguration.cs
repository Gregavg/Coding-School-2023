
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_16.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.ORM.Configurations {
    public class PetFoodConfiguration : IEntityTypeConfiguration<PetFood> {


        public void Configure(EntityTypeBuilder<PetFood> builder) {
            builder.ToTable("PetFood");

            builder.HasKey(petFood => petFood.ID);
            builder.Property(petFood => petFood.ID).HasMaxLength(100).IsRequired(true);

            builder.Property(petFood => petFood.Animaltype).HasMaxLength(50);

            builder.Property(petFood => petFood.Price).HasPrecision(20, 2);
            builder.Property(petFood => petFood.Qty).HasPrecision(20, 2);
            builder.Property(petFood => petFood.Cost).HasPrecision(20, 2);
            builder.Property(petFood => petFood.CurrentStock).HasPrecision(20, 2);



        }

    }
}
