
using Microsoft.EntityFrameworkCore;
using Session_16.Model;
using Session16.ORM.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.ORM.Repositories {
    public class PetFoodRepo : IEntityRepo<PetFood> {

        public void Add(PetFood entity) {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new AppDbContext();
            var dbPetshop= context.PetFoods.Where(petFood => petFood.ID == id).SingleOrDefault();
            if (dbPetshop is null)
                return;
            context.Remove(dbPetshop);
            context.SaveChanges();
        }

        public IList<PetFood> GetAll() {
            using var context = new AppDbContext();
            return context.PetFoods.ToList();
        }

        public PetFood? GetById(Guid id) {
            using var context = new AppDbContext();
            return context.PetFoods.Where(petFood => petFood.ID == id)
                .SingleOrDefault();
        }

        public void Update(Guid id, PetFood entity) {
            using var context = new AppDbContext();
            var dbPetshop = context.PetFoods.Where(petFood => petFood.ID == id).SingleOrDefault();
            if (dbPetshop is null)
                return;
            dbPetshop.Animaltype = entity.Animaltype;
            dbPetshop.Price = entity.Price;
            dbPetshop.Cost = entity.Cost;
            dbPetshop.Qty = entity.Qty;
            dbPetshop.CurrentStock = entity.CurrentStock;
            context.SaveChanges();
        }

        public void Clear() {
            using var context = new AppDbContext();
            var dbPetshop = context.PetFoods;

            foreach (var entity in dbPetshop)
                context.Remove(entity);
            context.SaveChanges();
        }

        public IList<Pet> GetAllAvailable() {
            throw new NotImplementedException();
        }
    }
}

