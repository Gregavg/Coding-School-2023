
using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Shared;
using FuelStation.Web.Shared.Validator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FuelStation.Web.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase {
        // Properties
        private readonly ITransactionRepo _transactionRepo;
        private readonly IValidator _validator;
        private readonly IItemRepo _itemRepo;
        public string errorMessage = string.Empty;

        // Constructors
        public TransactionController(ITransactionRepo transactionRepo, IValidator validator, IItemRepo itemRepo) {
            _transactionRepo = transactionRepo;
            _validator = validator;
            _itemRepo = itemRepo;
        }

        // GET: api/<TransactionController>
        [HttpGet]
        public async Task<IEnumerable<TransactionListDto>> Get() {
            var result = await Task.Run(() => { return _transactionRepo.GetAll(); });
            var selectTransactionList = result.Select(transaction => new TransactionListDto {
                Id = transaction.Id,
                Date = transaction.Date,
                TotalValue = transaction.TotalValue,
                PaymentMethod = transaction.PaymentMethod,
                CustomerId = transaction.CustomerId,
                EmployeeId = transaction.EmployeeId,
            });
            return selectTransactionList;
        }

        // GET: api/<TransactionController>
        [HttpGet("{id}")]
        public async Task<TransactionEditDto?> GetById(int id) {
            var result = await Task.Run(() => { return _transactionRepo.GetById(id); });
            if (result is null) {
                //Todo hlandle if result is null
                return null;
            }
            var transaction = new TransactionEditDto {
                Id = id,
                Date = result.Date,
                TotalValue = result.TotalValue,
                PaymentMethod = result.PaymentMethod,
                CustomerId = result.CustomerId,
                EmployeeId = result.EmployeeId,
            };

            return transaction;
        }

        // GET: api/<TransactionController>
        [Route("/transaction/customer/{id}")]
        [HttpGet]
        public async Task<IEnumerable<TransactionListDto?>> GetDetailsById(int id) {
            var result = await Task.Run(() => { return _transactionRepo.GetCustomerTransactions(id); });
            if (result is null) {
                return null;
            } else {
                var selectTransactionList = result.Select(transaction => new TransactionListDto {
                    Id = transaction.Id,
                    Date = transaction.Date,
                    TotalValue = transaction.TotalValue,
                    PaymentMethod = transaction.PaymentMethod,
                    CustomerId = transaction.CustomerId,
                    EmployeeId = transaction.EmployeeId,
                    //transaction Line
                    TransactionLines = transaction.TransactionLines.Select(transactionLine => new TransactionLineEditDto {
                        Id = transactionLine.Id,
                        Quantity = transactionLine.Quantity,
                        ItemPrice = transactionLine.ItemPrice,
                        NetValue = transactionLine.NetValue,
                        DiscountPercentage = transactionLine.DiscountPercentage,
                        DiscountValue = transactionLine.DiscountValue,
                        TotalValue = transactionLine.TotalValue,
                        TransactionId = transactionLine.TransactionId,
                        //Item
                        ItemId = transactionLine.ItemId,
                        Item = new ItemListDto {
                            Id = transactionLine.Item.Id,
                            Code = transactionLine.Item.Code,
                            Description = transactionLine.Item.Description,
                            Price = transactionLine.Item.Price,
                            Cost = transactionLine.Item.Cost,
                            ItemType = transactionLine.Item.ItemType,
                        },
                    }).ToList()
                }).ToList();
                return selectTransactionList;

            }
        }

        // POST api/<TransactionController>
        [HttpPost]
        public async Task<ActionResult> Post(TransactionEditDto transaction) {
            var newTransaction = new Transaction(transaction.TotalValue, transaction.PaymentMethod) {
                Date = transaction.Date,
                CustomerId = transaction.CustomerId,
                EmployeeId = transaction.EmployeeId,
            };
            if (transaction.TransactionLines != null) {
                newTransaction.TransactionLines = transaction.TransactionLines.Select(
                    transactionLine => new TransactionLine(
                    transactionLine.Quantity,
                    transactionLine.ItemPrice,
                    transactionLine.NetValue,
                    transactionLine.DiscountPercentage,
                    transactionLine.DiscountValue,
                    transactionLine.TotalValue,
                    transactionLine.ItemId)).ToList();
            }

            var items = _itemRepo.GetAll();

            if (_validator.ValidateAddTransaction(newTransaction, items, out errorMessage)){

            await Task.Run(() => { _transactionRepo.Add(newTransaction); });
                return Ok();
            }
            return BadRequest(errorMessage);
        }

        // PUT api/<TransactionController>/5
        [HttpPut]
        public async Task Put(TransactionEditDto transaction) {
            var dbTransaction = await Task.Run(() => { return _transactionRepo.GetById(transaction.Id); });
            if (dbTransaction is null) {
                return;
            }
            dbTransaction.Date = transaction.Date;
            dbTransaction.TotalValue = transaction.TotalValue;
            dbTransaction.PaymentMethod = transaction.PaymentMethod;
            dbTransaction.CustomerId = transaction.CustomerId;
            dbTransaction.EmployeeId = transaction.EmployeeId;

            await Task.Run(() => { _transactionRepo.Update(transaction.Id, dbTransaction); });
        }

        // DELETE api/<TransactionController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id) {
            try {
                await Task.Run(() => { _transactionRepo.Delete(id); });
                return Ok();
            }
            catch (Exception) {
                return BadRequest($"Could not delete this transaction");
            }

        }
    }
}
