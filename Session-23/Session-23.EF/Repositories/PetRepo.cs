
using Microsoft.EntityFrameworkCore;
using Session_23.EF.Context;
using Session_23.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Session_23.EF.Repositories {
    public class PetRepo : IEntityRepo<Pet> {

        public void Add(Pet entity) {
            using var context = new PetShopDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new PetShopDbContext();
            var dbPetshop = context.Pets.Where(pet => pet.Id == id).SingleOrDefault();
            if (dbPetshop is null)
                return;
            context.Remove(dbPetshop);
            context.SaveChanges();
        }

        public IList<Pet> GetAll() {
            using var context = new PetShopDbContext();
            return context.Pets.ToList();
        }



        public Pet? GetById(int id) {
            using var context = new PetShopDbContext();
            return context.Pets
                .Include(pet => pet.Transactions)
                .SingleOrDefault(pet => pet.Id == id);
        }

        public void Update(int id, Pet entity) {
            using var context = new PetShopDbContext();
            var dbPetshop = context.Pets.Where(pet => pet.Id == id).SingleOrDefault();
            if (dbPetshop is null)
                return;
            dbPetshop.AnimalType = entity.AnimalType;
            dbPetshop.PetStatus = entity.PetStatus;
            dbPetshop.Breed = entity.Breed;
            dbPetshop.Price = entity.Price;
            dbPetshop.Cost = entity.Cost;
            context.SaveChanges();
        }


        public void Clear() {
            using var context = new PetShopDbContext();
            var dbPetshop = context.Pets;

            foreach (var entity in dbPetshop)
                context.Remove(entity);
            context.SaveChanges();
        }

    }
}

