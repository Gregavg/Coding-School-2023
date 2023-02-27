
using Microsoft.EntityFrameworkCore;
using Session_16.Model;
using Session16.ORM.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.ORM.Repositories {
    public class TransactionRepo : IEntityRepo<Transaction> {

        public void Add(Transaction entity) {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new AppDbContext();
            var dbTransactionshop = context.Transactions.Where(transaction => transaction.ID == id).SingleOrDefault();
            if (dbTransactionshop is null)
                return;
            context.Remove(dbTransactionshop);
            context.SaveChanges();
        }

        public IList<Transaction> GetAll() {
            using var context = new AppDbContext();
            return context.Transactions.ToList();
        }

        public Transaction? GetById(Guid id) {
            using var context = new AppDbContext();
            return context.Transactions.Where(transaction => transaction.ID == id)
                .SingleOrDefault();
        }

        public void Update(Guid id, Transaction entity) {
            using var context = new AppDbContext();
            var dbPetshop = context.Transactions.Where(transaction => transaction.ID == id).SingleOrDefault();
            if (dbPetshop is null)
                return;
            dbPetshop.Date = entity.Date;
            dbPetshop.CustomerID = entity.CustomerID;
            dbPetshop.EmployeeID = entity.EmployeeID;
            dbPetshop.PetID = entity.PetID;
            dbPetshop.PetFoodID = entity.PetFoodID;
            dbPetshop.PetPrice = entity.PetPrice;
            dbPetshop.PetFoodQty = entity.PetFoodQty;
            dbPetshop.PetFoodPrice = entity.PetFoodPrice;
            dbPetshop.TotalPrice = entity.TotalPrice;
            context.SaveChanges();
        }


        public void Clear() {
            using var context = new AppDbContext();
            var dbPetshop = context.Transactions;

            foreach (var entity in dbPetshop)
                context.Remove(entity);
            context.SaveChanges();
        }

        public IList<Pet> GetAllAvailable() {
            throw new NotImplementedException();
        }
    }
}

