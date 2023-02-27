
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Session_16.Model;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Session_16.EF.ORM.Configurations {
//    public class PetFoodTransaction : IEntityTypeConfiguration<PetFoodTransaction> {


//        public void Configure(EntityTypeBuilder<PetFoodTransaction> builder) {
//            builder.ToTable("PetFoodTransaction");

//            builder.HasKey(petFoodTransaction => petFoodTransaction.ID);
//            builder.Property(petFoodTransaction => petFoodTransaction.ID).IsRequired(true);



//            ////foreign PetFoodTransaction
//            //builder.HasOne(petFoodTrans => petFoodTrans.Petfood)
//            //    .WithMany(petFood => petFood.PetFoodTransactions)
//            //    .HasForeignKey(petFoodTrans => petFoodTrans.ID);

//        }

//    }
//}
