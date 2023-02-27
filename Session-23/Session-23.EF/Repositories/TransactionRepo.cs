using Microsoft.EntityFrameworkCore;
using Session_23.EF.Context;
using Session_23.Model;

namespace Session_23.EF.Repositories {
    public class TransactionRepo : IEntityRepo<Transaction> {

        public void Add(Transaction entity) {
            using var context = new PetShopDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new PetShopDbContext();
            var dbTransactionshop = context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();
            if (dbTransactionshop is null)
                return;
            context.Remove(dbTransactionshop);
            context.SaveChanges();
        }

        public IList<Transaction> GetAll() {
            using var context = new PetShopDbContext();
            return context.Transactions.Include(customer => customer.Customer)
                .Include(employee => employee.Employee)
                .Include(pet => pet.Pet)
                .Include(petFood => petFood.PetFood)
                .ToList();
        }

        public Transaction? GetById(int id) {
            using var context = new PetShopDbContext();
            return context.Transactions.Where(transaction => transaction.Id == id)
                .SingleOrDefault();
        }

        public void Update(int id, Transaction entity) {
            using var context = new PetShopDbContext();
            var dbPetshop = context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();
            if (dbPetshop is null)
                return;
            dbPetshop.Date = entity.Date;
            dbPetshop.CustomerId = entity.CustomerId;
            dbPetshop.EmployeeId = entity.EmployeeId;
            dbPetshop.PetId = entity.PetId;
            dbPetshop.PetFoodId = entity.PetFoodId;
            dbPetshop.PetPrice = entity.PetPrice;
            dbPetshop.PetFoodQty = entity.PetFoodQty;
            dbPetshop.PetFoodPrice = entity.PetFoodPrice;
            dbPetshop.TotalPrice = entity.TotalPrice;
            context.SaveChanges();
        }


        public void Clear() {
            using var context = new PetShopDbContext();
            var dbPetshop = context.Transactions;

            foreach (var entity in dbPetshop)
                context.Remove(entity);
            context.SaveChanges();
        }
        
    }
}

