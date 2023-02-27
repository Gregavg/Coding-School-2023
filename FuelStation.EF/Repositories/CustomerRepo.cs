using FuelStation.Model;
using FuelStation.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories {
    public class CustomerRepo : IEntityRepo<Customer>, ICustomerRepo {
        public void Add(Customer entity) {
            using var context = new FuelStationDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new FuelStationDbContext();
            var dbCustomer = context.Customers.Where(customer => customer.Id == id).SingleOrDefault();
            if (dbCustomer is null)
                return;
            context.Remove(dbCustomer);
            context.SaveChanges();
        }

        public IList<Customer> GetAll() {
            using var context = new FuelStationDbContext();
            return context.Customers
                .Include(customer => customer.Transactions).ToList();
        }

        public Customer? GetById(int id) {
            using var context = new FuelStationDbContext();
            return context.Customers
              .Include(customer => customer.Transactions)
              .ThenInclude(transaction => transaction.Employee)
              .Where(customer => customer.Id == id)
              .SingleOrDefault();

        }

        public void Update(int id, Customer entity) {
            using var context = new FuelStationDbContext();
            var dbCustomer = context.Customers.Where(customer => customer.Id == id).SingleOrDefault();
            if (dbCustomer is null)
                return;
            dbCustomer.CardNumber = entity.CardNumber;
            dbCustomer.Name = entity.Name;
            dbCustomer.Surname = entity.Surname;
            try {
                context.SaveChanges();
            }
            catch (Exception ex) {
                throw ex;
            }

        }

        public Customer? GetByCardNumber(string cardNumber) {
            using var context = new FuelStationDbContext();
            return context.Customers.Where(customer => customer.CardNumber == cardNumber)
                .Include(customer => customer.Transactions)
                .ThenInclude(transaction => transaction.TransactionLines)
                .SingleOrDefault();
        }
    }
}
