using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories {
    public class EmployeeRepo : IEntityRepo<Employee> {
        public void Add(Employee entity) {
            using var context = new FuelStationDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new FuelStationDbContext();
            var dbFuelStation = context.Employees.Where(employee => employee.Id == id).SingleOrDefault();
            if (dbFuelStation is null)
                return;
            context.Remove(dbFuelStation);
            context.SaveChanges();
        }

        public IList<Employee> GetAll() {
            using var context = new FuelStationDbContext();
            return context.Employees.Include(transactions => transactions.Transactions).ToList();
        }

        public Employee? GetById(int id) {
            using var context = new FuelStationDbContext();
            return context.Employees.Where(employee => employee.Id == id)
                .Include(transactions => transactions.Transactions)
                .SingleOrDefault();
        }

        public void Update(int id, Employee entity) {
            using var context = new FuelStationDbContext();
            var dbEmployee = context.Employees.Where(employee => employee.Id == id).SingleOrDefault();
            if (dbEmployee is null)
                return;
            dbEmployee.Name = entity.Name;
            dbEmployee.Surname = entity.Surname;
            dbEmployee.SalaryPerMonth = entity.SalaryPerMonth;
            dbEmployee.EmployeeType = entity.EmployeeType;
            dbEmployee.HireDateStart = entity.HireDateStart;
            dbEmployee.HireDateEnd = entity.HireDateEnd;
            context.SaveChanges();
        }
    }
}
