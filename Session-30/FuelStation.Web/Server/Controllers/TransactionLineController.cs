
using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Model.Enums;
using FuelStation.Web.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace FuelStation.Web.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class TransactionLineController : ControllerBase {
        // Properties
        private readonly IEntityRepo<TransactionLine> _transactionLineRepo;

        // Constructors
        public TransactionLineController(IEntityRepo<TransactionLine> transactionLineRepo) {
            _transactionLineRepo = transactionLineRepo;

        }

        // GET: api/<TransactionController>
        [HttpGet]
        //[Authorize(Roles = "Manager, Cashier")]
        public async Task<IEnumerable<TransactionLineListDto>> Get() {
            var result = await Task.Run(() => _transactionLineRepo.GetAll());

            var selectTransactionLineList = result.Select(transactionLine => GetTransactionLineList(transactionLine));

            return selectTransactionLineList;
        }

        public TransactionLineListDto GetTransactionLineList(TransactionLine result) {
            var transaction = new TransactionLineListDto {
                Id = result.Id,
                Quantity = result.Quantity,
                ItemPrice = result.ItemPrice,
                NetValue = result.NetValue,
                DiscountPercentage = result.DiscountPercentage,
                DiscountValue = result.DiscountValue,
                TotalValue = result.TotalValue,
                ItemId = result.ItemId,
                Item = new ItemListDto {
                    Id = result.Item.Id,
                    Code = result.Item.Code,
                    Description = result.Item.Description,
                    Price = result.Item.Price,
                    Cost = result.Item.Cost,
                    ItemType = result.Item.ItemType,
                }
            };
            return transaction;
        }

        // GET: api/<TransactionController>
        [HttpGet("{id}")]
        //[Authorize(Roles = "Manager, Cashier")]
        public async Task<TransactionLineListDto?> GetById(int id) {
            var result = await Task.Run(() => { return _transactionLineRepo.GetById(id); });
            if (result is null) {
                return null;
            }
            var transaction = GetTransactionLineList(result);

            return transaction;
        }


        // POST api/<TransactionController>
        [HttpPost]
        [Authorize(Roles = "Manager, Cashier")]
        public async Task Post(TransactionLineEditDto transactionLine) {
            var newTransaction = new TransactionLine(
                transactionLine.Quantity,
                transactionLine.ItemPrice,
                transactionLine.NetValue,
                transactionLine.DiscountPercentage,
                transactionLine.DiscountValue,
                transactionLine.TotalValue,
                transactionLine.ItemId);
            newTransaction.TransactionId = transactionLine.TransactionId;
            await Task.Run(() => { _transactionLineRepo.Add(newTransaction); });
        }

        // PUT api/<TransactionController>/5
        [HttpPut]
        //[Authorize(Roles = "Manager, Cashier")]
        public async Task Put(TransactionLineEditDto transactionLine) {
            var dbTransactionLine = await Task.Run(() => { return _transactionLineRepo.GetById(transactionLine.Id); });
            if (dbTransactionLine is null) {
                return;
            }
            dbTransactionLine.Id = transactionLine.Id;
            dbTransactionLine.Quantity = transactionLine.Quantity;
            dbTransactionLine.ItemPrice = transactionLine.ItemPrice;
            dbTransactionLine.NetValue = transactionLine.NetValue;
            dbTransactionLine.DiscountPercentage = transactionLine.DiscountPercentage;
            dbTransactionLine.DiscountValue = transactionLine.DiscountValue;
            dbTransactionLine.TotalValue = transactionLine.TotalValue;
            dbTransactionLine.ItemId = transactionLine.ItemId;
            dbTransactionLine.TransactionId = transactionLine.TransactionId;
            await Task.Run(() => { _transactionLineRepo.Update(transactionLine.Id, dbTransactionLine); });
        }

        // DELETE api/<TransactionController>/5
        [HttpDelete("{id}")]
        //[Authorize(Roles = "Manager, Cashier")]
        public async Task<ActionResult> Delete(int id) {
            try {
                await Task.Run(() => { _transactionLineRepo.Delete(id); });
                return Ok();
            }
            catch (DbUpdateException) {
                return BadRequest($"Could not delete this transactionLine");
            }
            catch (KeyNotFoundException) {
                return BadRequest($"TransactionLine not found");
            }
        }
    }
}
