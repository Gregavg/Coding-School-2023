
using Microsoft.EntityFrameworkCore;
using Session_23.EF.Context;
using Session_23.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_23.EF.Repositories {
    public class EmployeeRepo : IEntityRepo<Employee> {

        public void Add(Employee entity) {
            using var context = new PetShopDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int  id) {
            using var context = new PetShopDbContext();
            var dbPetshop = context.Employees.Where(employee => employee.Id == id).SingleOrDefault();
            if (dbPetshop is null)
                return;
            context.Remove(dbPetshop);
            context.SaveChanges();
        }


        public IList<Employee> GetAll() {
            using var context = new PetShopDbContext();
            return context.Employees.ToList();
        }

        public Employee? GetById(int id) {
            using var context = new PetShopDbContext();
            return context.Employees.Include(employee => employee.Transactions)
                .SingleOrDefault(employee => employee.Id == id);
        }

        public void Update(int id, Employee entity) {
            using var context = new PetShopDbContext();
            var dbPetshop = context.Employees.Where(employee => employee.Id == id).SingleOrDefault();
            if (dbPetshop is null)
                return;
            dbPetshop.Name = entity.Name;
            dbPetshop.Surname = entity.Surname;
            dbPetshop.EmployeeType = entity.EmployeeType;
            dbPetshop.SalaryPerMonth = entity.SalaryPerMonth;
            context.SaveChanges();
        }

        public void Clear() {
            using var context = new PetShopDbContext();
            var dbPetshop = context.Employees;

            foreach (var entity in dbPetshop)
                context.Remove(entity);
            context.SaveChanges();
        }


    }
}

