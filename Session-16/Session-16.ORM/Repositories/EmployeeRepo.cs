
using Microsoft.EntityFrameworkCore;
using Session_16.Model;
using Session16.ORM.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.ORM.Repositories {
    public class EmployeeRepo : IEntityRepo<Employee> {

        public void Add(Employee entity) {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new AppDbContext();
            var dbPetshop = context.Employees.Where(employee => employee.ID == id).SingleOrDefault();
            if (dbPetshop is null)
                return;
            context.Remove(dbPetshop);
            context.SaveChanges();
        }
        public void Clear() {
            using var context = new AppDbContext();
            var dbPetshop = context.Employees;

            foreach (var entity in dbPetshop)
                context.Remove(entity);
            context.SaveChanges();
        }

        public IList<Employee> GetAll() {
            using var context = new AppDbContext();
            return context.Employees.ToList();
        }

        public Employee? GetById(Guid id) {
            using var context = new AppDbContext();
            return context.Employees.Where(employee => employee.ID == id)
                .SingleOrDefault();
        }

        public void Update(Guid id, Employee entity) {
            using var context = new AppDbContext();
            var dbPetshop = context.Employees.Where(employee => employee.ID == id).SingleOrDefault();
            if (dbPetshop is null)
                return;
            dbPetshop.Name = entity.Name;
            dbPetshop.Surname = entity.Surname;
            dbPetshop.EmpType = entity.EmpType;
            dbPetshop.SalaryPerMonth = entity.SalaryPerMonth;
            context.SaveChanges();
        }

        public IList<Pet> GetAllAvailable() {
            throw new NotImplementedException();
        }
    }
}

