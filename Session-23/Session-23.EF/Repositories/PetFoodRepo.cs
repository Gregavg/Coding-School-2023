using Microsoft.EntityFrameworkCore;
using Session_23.EF.Context;
using Session_23.Model;

namespace Session_23.EF.Repositories {
    public class PetFoodRepo : IEntityRepo<PetFood> {

        public void Add(PetFood entity) {
            using var context = new PetShopDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new PetShopDbContext();
            var dbPetshop= context.PetFoods.Where(petFood => petFood.Id == id).SingleOrDefault();
            if (dbPetshop is null)
                return;
            context.Remove(dbPetshop);
            context.SaveChanges();
        }

        public IList<PetFood> GetAll() {
            using var context = new PetShopDbContext();
            return context.PetFoods.ToList();
        }

        public PetFood? GetById(int id) {
            using var context = new PetShopDbContext();
            return context.PetFoods
                .Include(petFood => petFood.Transactions)
                .SingleOrDefault(petFood => petFood.Id == id);
        }

        public void Update(int id, PetFood entity) {
            using var context = new PetShopDbContext();
            var dbPetshop = context.PetFoods.Where(petFood => petFood.Id == id).SingleOrDefault();
            if (dbPetshop is null)
                return;
            dbPetshop.AnimalType = entity.AnimalType;
            dbPetshop.Price = entity.Price;
            dbPetshop.Cost = entity.Cost;
            context.SaveChanges();
        }

        public void Clear() {
            using var context = new PetShopDbContext();
            var dbPetshop = context.PetFoods;

            foreach (var entity in dbPetshop)
            context.Remove(entity);
            context.SaveChanges();
        }

    }
}

