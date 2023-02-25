
using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FuelStation.Web.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase {
        // Properties
        private readonly ICustomerRepo _customerRepo;

        // Constructors
        public CustomerController(ICustomerRepo customerRepo) {
            _customerRepo = customerRepo;
        }

        // GET: api/<CustomersController>
        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public async Task<IEnumerable<CustomerListDto>> Get() {
            var result = await Task.Run(() => { return _customerRepo.GetAll(); });

            var selectCustomerList = result.Select(customer => new CustomerListDto {
                Id = customer.Id,
                Name = customer.Name,
                Surname = customer.Surname,
                CardNumber = customer.CardNumber,

            });

            return selectCustomerList;
        }

        // GET: api/<CustomersController>
        [HttpGet("{id}")]
        public async Task<CustomerEditDto?> GetById(int id) {
            var result = await Task.Run(() => { return _customerRepo.GetById(id); });
            if (result == null) {
                return null;
            }
            CustomerEditDto customer = new() {
                Id = id,
                Name = result.Name,
                Surname = result.Surname,
                CardNumber = result.CardNumber,

            };
            return customer;
        }

        //_transactionRepo
        // GET: api/<CustomersController>
        [Route("/customerlist/customer/details/{id}")]
        [HttpGet]
        public async Task<CustomerDetailsDto?> GetDetailsByCardNumber(int id) {
            var result = await Task.Run(() => { return _customerRepo.GetById(id); });
            if (result is null) {
                return null;
            } else {
                CustomerDetailsDto? customer = new() {
                    Id = result.Id,
                    Name = result.Name,
                    Surname = result.Surname,
                    CardNumber = result.CardNumber,
                    Transactions = result.Transactions.Select(transaction => new CustomerTransactionDetailsDto {
                        Date = transaction.Date,
                        PaymentMethod = transaction.PaymentMethod,
                        TotalValue = transaction.TotalValue,
                        Id = transaction.Id,
                        Employee = new CustomerEmployeeDetailsDto {
                            Id = transaction.Employee.Id,
                            Name = transaction.Employee.Name,
                            Surname = transaction.Employee.Surname,
                        }
                    }).ToList()
                };
                return customer;
            }
        }

        // GET: api/<CustomersController>
        [Route("/customer/cardnumber/{cardnumber}")]
        [HttpGet]
        public async Task<CustomerListDto?> GetDetailsByCardNumber(string cardnumber) {
            var result = await Task.Run(() => { return _customerRepo.GetByCardNumber(cardnumber); });
            if (result is null) {
                return null;
            } else {
                CustomerListDto transaction = new() {
                    Id = result.Id,
                    Name = result.Name,
                    Surname = result.Surname,
                    CardNumber = result.CardNumber,
                };
                return transaction;
            }
        }


        // POST api/<CustomersController>
        [HttpPost]
        public async Task<ActionResult> Post(CustomerEditDto customer) {
            var newCustomer = new Customer(customer.Name, customer.Surname, customer.CardNumber);
            try {
                await Task.Run(() => { _customerRepo.Add(newCustomer); });
                return Ok();
            }
            catch (DbUpdateException) {

                return BadRequest("Card number already assigned. Please try again.");
            }

        }

        // PUT api/<CustomersController>/5  
        [HttpPut]
        public async Task<ActionResult> Put(CustomerEditDto customer) {

            if (!customer.CardNumber.StartsWith("A")) {
                return BadRequest("Card number does not start with A. Please try again.");
            }
            var dbCustomer = await Task.Run(() => { return _customerRepo.GetById(customer.Id); });
            if (dbCustomer == null) {
                return BadRequest("Can not found. Please try again."); ;
            }
            dbCustomer.Name = customer.Name;
            dbCustomer.Surname = customer.Surname;
            dbCustomer.CardNumber = customer.CardNumber;


            try {
                await Task.Run(() => { _customerRepo.Update(customer.Id, dbCustomer); });
                return Ok();
            }
            catch (DbUpdateException) {
                return BadRequest("Card number already assigned. Please try again.");
            }
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id) {
            try {
                var result = await Task.Run(() => { return _customerRepo.GetById(id); });
                if (result != null) {
                    if (result.Transactions == null || result.Transactions.Count == 0) {
                        await Task.Run(() => { _customerRepo.Delete(id); });
                        return Ok();
                    }
                }
                return BadRequest($"Could not delete this Customer");
            }
            catch (Exception) {
                return BadRequest($"Could not delete this Customer");
            }

        }
    }
}
