
using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Shared;
using FuelStation.Web.Shared.Validator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.Common;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FuelStation.Web.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase {
        // Properties
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IValidator _validator;
        public string errorMessage = string.Empty;

        // Constructors
        public EmployeeController(IEntityRepo<Employee> employeeRepo, IValidator validator) {
            _employeeRepo = employeeRepo;
            _validator = validator;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        //[Authorize(Roles = "Manager")]
        public async Task<IEnumerable<EmployeeListDto>> Get() {
            var result = await Task.Run(() => { return _employeeRepo.GetAll(); });
            var selectEmployeeList = result.Select(employee => new EmployeeListDto {
                Id = employee.Id,
                Name = employee.Name,
                Surname = employee.Surname,
                SalaryPerMonth = employee.SalaryPerMonth,
                EmployeeType = employee.EmployeeType,
                HireDateEnd = employee.HireDateEnd,
                HireDateStart = employee.HireDateStart,
            });
            return selectEmployeeList;
        }

        // GET: api/<EmployeeController>
        [HttpGet("{id}")]
        //[Authorize(Roles = "Manager")]
        public async Task<EmployeeEditDto?> GetById(int id) {
            var result = await Task.Run(() => { return _employeeRepo.GetById(id); });
            if (result == null) {
                return null;
            } else {
                return new EmployeeEditDto {
                    Id = id,
                    Name = result.Name,
                    Surname = result.Surname,
                    SalaryPerMonth = result.SalaryPerMonth,
                    EmployeeType = result.EmployeeType,
                    HireDateStart = result.HireDateStart,
                    HireDateEnd = result.HireDateEnd,
                };
            }
        }

        // GET: api/<ProductsController>
        [Route("/employee/details/{id}")]
        [HttpGet]
        //[Authorize(Roles = "Manager")]
        public async Task<EmployeeDetailsDto?> GetDetailsById(int id) {
            var result = await Task.Run(() => { return _employeeRepo.GetById(id); });
            if (result is null) {
                return null;
            } else {
                return new EmployeeDetailsDto {
                    Id = id,
                    Name = result.Name,
                    Surname = result.Surname,
                    SalaryPerMonth = result.SalaryPerMonth,
                    EmployeeType = result.EmployeeType,
                    HireDateEnd = result.HireDateEnd,
                    HireDateStart = result.HireDateStart,
                    Transactions = result.Transactions.Select(transaction => new EmployeeTransactionDetailsDto {
                        Date = transaction.Date,
                        PaymentMethod = transaction.PaymentMethod,
                        TotalValue = transaction.TotalValue,
                        Id = transaction.Id,
                    }).ToList()
                };
            }
        }

        // POST api/<EmployeeController>
        [HttpPost]
        //[Authorize(Roles = "Manager")]
        public async Task<ActionResult> Post(EmployeeEditDto employee) {

            var newEmployee = new Employee(employee.Name, employee.Surname, employee.SalaryPerMonth, employee.EmployeeType, employee.HireDateStart, employee.HireDateEnd);
            var employees = _employeeRepo.GetAll().ToList();
            if (_validator.ValidateAddEmployee(newEmployee.EmployeeType, employees, out errorMessage, newEmployee)) {
                try {
                    await Task.Run(() => { _employeeRepo.Add(newEmployee); });
                }
                catch (DbException ex) {
                    return BadRequest(ex.Message);
                }
                return Ok();
            }
            return BadRequest(errorMessage);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut]
        //[Authorize(Roles = "Manager")]
        public async Task<ActionResult> Put(EmployeeEditDto employee) {
            var dbEmployee = await Task.Run(() => { return _employeeRepo.GetById(employee.Id); });
            if (dbEmployee == null) {
                return BadRequest($"Employee not found");

            } else {
                dbEmployee.Name = employee.Name;
                dbEmployee.Surname = employee.Surname;
                dbEmployee.SalaryPerMonth = employee.SalaryPerMonth;
                dbEmployee.HireDateStart = employee.HireDateStart;
                dbEmployee.HireDateEnd = employee.HireDateEnd;

                if (_validator.ValidateUpdateEmployee(employee.EmployeeType, dbEmployee, _employeeRepo.GetAll().ToList(), out errorMessage)) {

                    dbEmployee.EmployeeType = employee.EmployeeType;
                    try {
                        _employeeRepo.Update(employee.Id, dbEmployee);
                    }
                    catch (DbUpdateException ex) {
                        return BadRequest(ex.Message);
                    }
                    return Ok();
                } else {
                    return BadRequest(errorMessage);
                }
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        //[Authorize(Roles = "Manager")]
        public async Task<ActionResult> Delete(int id) {

            try {
                var result = await Task.Run(() => { return _employeeRepo.GetById(id); });
                if (result != null) {
                    if (result.Transactions == null || result.Transactions.Count == 0) {
                        await Task.Run(() => { _employeeRepo.Delete(id); });
                        return Ok();
                    }
                }
                return BadRequest($"Could not delete this Employee");
            }
            catch (Exception) {
                return BadRequest($"Could not delete this Employee");
            }
        }
    }
}
