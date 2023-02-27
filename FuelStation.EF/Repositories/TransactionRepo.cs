using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories {
    public class TransactionRepo : IEntityRepo<Transaction>, ITransactionRepo {
        public void Add(Transaction entity) {
            using var context = new FuelStationDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new FuelStationDbContext();
            var dbFuelStation = context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();
            if (dbFuelStation is null)
                return;
            context.Remove(dbFuelStation);
            context.SaveChanges();
        }

        public IList<Transaction> GetAll() {
            using var context = new FuelStationDbContext();

            var transactions = context.Transactions
            .Include(transaction => transaction.TransactionLines)
                .ThenInclude(transactionLines => transactionLines.Item)
            .Include(transaction => transaction.Customer)
            .Include(transaction => transaction.Employee)
            .ToList();

            return transactions;
        }

        public Transaction? GetById(int id) {
            using var context = new FuelStationDbContext();
            return context.Transactions
                .Where(transaction => transaction.Id == id)
                .Include(Transaction => Transaction.TransactionLines)
                .Include(transaction => transaction.Customer)
                .Include(transaction => transaction.Employee)
                .SingleOrDefault();
        }

        public void Update(int id, Transaction entity) {
            using var context = new FuelStationDbContext();
            var dbTransaction = context.Transactions.Where(transaction => transaction.Id == id)
                .Include(Transaction => Transaction.TransactionLines).SingleOrDefault();
            if (dbTransaction is null)
                return;
            dbTransaction.Date = entity.Date;
            dbTransaction.TotalValue = entity.TotalValue;
            dbTransaction.PaymentMethod = entity.PaymentMethod;
            dbTransaction.CustomerId = entity.CustomerId;
            dbTransaction.EmployeeId = entity.EmployeeId;
            dbTransaction.TransactionLines = entity.TransactionLines;
            context.SaveChanges();
        }



        public IList<Transaction> GetCustomerTransactions(int id) {
            using var context = new FuelStationDbContext();
            return context.Transactions
                .Where(transaction => transaction.CustomerId == id)
                .Include(transaction => transaction.TransactionLines)
                .ThenInclude(transactionLines => transactionLines.Item)
                //.Include(transaction => transaction.Customer)
                //.Include(transaction => transaction.Employee)
                .ToList();
        }
    }
}
