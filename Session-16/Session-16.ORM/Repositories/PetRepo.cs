
using Microsoft.EntityFrameworkCore;
using Session_16.Model;
using Session16.ORM.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Session_16.ORM.Repositories {
    public class PetRepo : IEntityRepo<Pet> {

        public void Add(Pet entity) {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new AppDbContext();
            var dbPetshop = context.Pets.Where(pet => pet.ID == id).SingleOrDefault();
            if (dbPetshop is null)
                return;
            context.Remove(dbPetshop);
            context.SaveChanges();
        }

        public IList<Pet> GetAll() {
            using var context = new AppDbContext();
            return context.Pets.ToList();
        }

        public IList<Pet> GetAllAvailable() {
            using var context = new AppDbContext();
            var dbPetshop = context.Pets.Where(pet => /*(pet.TransactionID == null) &&*/ (pet.Petstatus != PetStatus.Unhealthy));
            return dbPetshop.ToList();
        }

        public Pet? GetById(Guid id) {
            using var context = new AppDbContext();
            return context.Pets.Where(pet => pet.ID == id)
                .SingleOrDefault();
        }

        public void Update(Guid id, Pet entity) {
            using var context = new AppDbContext();
            var dbPetshop = context.Pets.Where(pet => pet.ID == id).SingleOrDefault();
            if (dbPetshop is null)
                return;
            dbPetshop.Animaltype = entity.Animaltype;
            dbPetshop.Petstatus = entity.Petstatus;
            dbPetshop.Breed = entity.Breed;
            dbPetshop.Price = entity.Price;
            dbPetshop.Cost = entity.Cost;
            dbPetshop.Bought = entity.Bought;
            dbPetshop.TransactionID = entity.TransactionID;
            context.SaveChanges();
        }

        public void UpdateTransactionId(Guid id, Guid? petid) {
            using var context = new AppDbContext();
            var dbPetshop = context.Pets.Where(pet => pet.ID == petid).SingleOrDefault();
            if (dbPetshop is null)
                return;
            dbPetshop.TransactionID = id;
            context.SaveChanges();
        }
        public void ClearTransaction(Guid id) {
            using var context = new AppDbContext();
            var dbPetshop = context.Pets.Where(pet => pet.TransactionID == id).SingleOrDefault();
            if (dbPetshop is null)
                return;
            dbPetshop.TransactionID = null;
            context.SaveChanges();
        }




        public void Clear() {
            using var context = new AppDbContext();
            var dbPetshop = context.Pets;

            foreach (var entity in dbPetshop)
                context.Remove(entity);
            context.SaveChanges();
        }


    }
}

