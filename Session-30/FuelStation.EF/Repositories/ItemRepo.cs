using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories {
    public class ItemRepo : IEntityRepo<Item>, IItemRepo {
        public void Add(Item entity) {
            using var context = new FuelStationDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            try {
                using var context = new FuelStationDbContext();
                var dbItem = context.Items.Where(item => item.Id == id).SingleOrDefault();
                if (dbItem is null)
                    return;
                context.Remove(dbItem);
                context.SaveChanges();
            }
            catch (Exception ex) {
                throw ex;
            }

        }

        public IList<Item> GetAll() {
            using var context = new FuelStationDbContext();
            return context.Items
                .Include(item => item.TransactionLines)
                .ToList();
        }

        public Item? GetById(int id) {
            using var context = new FuelStationDbContext();
            return context.Items.Where(item => item.Id == id)
                .Include(item => item.TransactionLines)
                .SingleOrDefault();
        }

        public void Update(int id, Item entity) {
            using var context = new FuelStationDbContext();
            var dbItem = context.Items.Where(item => item.Id == id).SingleOrDefault();
            if (dbItem is null)
                return;
            dbItem.Code = entity.Code;
            dbItem.Description = entity.Description;
            dbItem.Price = entity.Price;
            dbItem.Cost = entity.Cost;
            dbItem.ItemType = entity.ItemType;
            context.SaveChanges();
        }

        public Item? GetByCode(string code) {
            using var context = new FuelStationDbContext();
            return context.Items.Where(item => item.Code == code)
                .SingleOrDefault();
        }
    }
}




