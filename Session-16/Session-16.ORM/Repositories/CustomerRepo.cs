
using Session16.ORM.Context;
using Microsoft.EntityFrameworkCore;
using Session_16.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Session_16.ORM.Repositories {
    public class CustomerRepo : IEntityRepo<Customer> {

        public void Add(Customer entity) {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new AppDbContext();
            var dbPetshop = context.Customers.Where(customer => customer.ID == id).SingleOrDefault();
            if (dbPetshop is null)
                return;
            context.Remove(dbPetshop);
            context.SaveChanges();
        }

        public void Clear() {
            using var context = new AppDbContext();
            var dbPetshop = context.Customers;

            foreach (var entity in dbPetshop)
                context.Remove(entity);
            context.SaveChanges();
        }


        public IList<Customer> GetAll() {
            using var context = new AppDbContext();
            return context.Customers.ToList();
        }

        public Customer? GetById(Guid id) {
            using var context = new AppDbContext();
            return context.Customers.Where(customer => customer.ID == id)
                .SingleOrDefault();
        }

        public void Update(Guid id, Customer entity) {
            using var context = new AppDbContext();
            var dbPetshop = context.Customers.Where(customer => customer.ID == id).SingleOrDefault();
            if (dbPetshop is null)
                return;
            dbPetshop.Name = entity.Name;
            dbPetshop.Surname = entity.Surname;
            dbPetshop.Phone = entity.Phone;
            dbPetshop.TIN = entity.TIN;
            context.SaveChanges();
        }

        public IList<Pet> GetAllAvailable() {
            throw new NotImplementedException();
        }
    }
}

