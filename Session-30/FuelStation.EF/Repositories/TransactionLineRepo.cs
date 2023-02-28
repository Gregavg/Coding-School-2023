using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories {
    public class TransactionLineRepo : IEntityRepo<TransactionLine> {
        public void Add(TransactionLine entity) {
            using var context = new FuelStationDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new FuelStationDbContext();
            var dbFuelStation = context.TransactionLines.Where(transactionline => transactionline.Id == id)
                .Include(transactionline => transactionline.Item).SingleOrDefault();
            if (dbFuelStation is null)
                return;
            context.Remove(dbFuelStation);
            context.SaveChanges();
        }

        public IList<TransactionLine> GetAll() {
            using var context = new FuelStationDbContext();
            return context.TransactionLines.Include(item => item.Item).ToList();
        }

        public TransactionLine? GetById(int id) {
            using var context = new FuelStationDbContext();
            return context.TransactionLines
                .Where(transactionline => transactionline.Id == id)
                .Include(transactionLine => transactionLine.Item)
                .SingleOrDefault();
        }

        public void Update(int id, TransactionLine entity) {
            using var context = new FuelStationDbContext();
            var dbTransactionLine = context.TransactionLines.Where(transactionline => transactionline.Id == id).SingleOrDefault();
            if (dbTransactionLine is null)
                return;
            dbTransactionLine.Quantity = entity.Quantity;
            dbTransactionLine.ItemPrice = entity.ItemPrice;
            dbTransactionLine.NetValue = entity.NetValue;
            dbTransactionLine.DiscountPercentage = entity.DiscountPercentage;
            dbTransactionLine.DiscountValue = entity.DiscountPercentage;
            dbTransactionLine.TotalValue = entity.DiscountPercentage;

            //RELATIONS
            //dbTransactionLine.TransactionId = entity.TransactionId;
            //dbTransactionLine.ItemId = entity.ItemId;

            //try { }
            context.SaveChanges();
        }
    }
}
