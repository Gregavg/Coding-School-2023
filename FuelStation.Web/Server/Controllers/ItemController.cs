

using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FuelStation.Web.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class ItemController : ControllerBase {
        // Properties
        private readonly IItemRepo _itemRepo;
        private readonly IEntityRepo<TransactionLine> _transactionLineRepo;

        // Constructors
        public ItemController(IItemRepo itemRepo, IEntityRepo<TransactionLine> transactionLineRepo) {
            _itemRepo = itemRepo;
            _transactionLineRepo = transactionLineRepo;
        }

        // GET: api/<ItemsController>
        [HttpGet]
        //[Authorize(Roles = "Manager, Staff")]
        public async Task<IEnumerable<ItemListDto>> Get() {
            var result = await Task.Run(() => { return _itemRepo.GetAll(); });
            var selectItemList = result.Select(item => new ItemListDto {
                Id = item.Id,
                Code = item.Code,
                Description = item.Description,
                Cost = item.Cost,
                Price = item.Price,
                ItemType = item.ItemType,
            });
            return selectItemList;
        }

        // GET: api/<ItemsController>
        [HttpGet("{id}")]
        //[Authorize(Roles = "Manager, Staff")]
        public async Task<ItemEditDto?> GetById(int id) {
            var result = await Task.Run(() => { return _itemRepo.GetById(id); });
            if (result is null) {
                return null;
            } else {
                return new ItemEditDto {
                    Id = id,
                    Code = result.Code,
                    Description = result.Description,
                    Cost = result.Cost,
                    Price = result.Price,
                    ItemType = result.ItemType,
                };
            }
        }

        // GET: api/<ItemsController>
        [Route("/itemlist/details/{id}")]
        [HttpGet]
        //[Authorize(Roles = "Manager, Staff")]
        public async Task<ItemDetailsDto?> GetDetailsById(int id) {
            var result = await Task.Run(() => { return _itemRepo.GetById(id); });
            if (result is null) {
                return null;
            } else {

                var transactionLines = _transactionLineRepo.GetAll().Select(tl => new ItemTransactionLineDetailsDto {
                    Id = tl.Id,
                    ItemId = tl.ItemId,
                    Quantity = tl.Quantity,
                    ItemPrice = tl.ItemPrice,
                    NetValue = tl.NetValue,
                    DiscountPercentage = tl.DiscountPercentage,
                    DiscountValue = tl.DiscountValue,
                    TotalValue = tl.TotalValue
                }).Where(tl => tl.ItemId == id).ToList();

                return new ItemDetailsDto {
                    Id = id,
                    Code = result.Code,
                    Description = result.Description,
                    Cost = result.Cost,
                    Price = result.Price,
                    ItemType = result.ItemType,
                    TransactionLines = transactionLines,
                };
            }
        }


        // POST api/<ItemsController>
        [HttpPost]
        //[Authorize(Roles = "Manager, Staff")]
        public async Task<ActionResult> Post(ItemEditDto item) {
            var newItem = new Item(item.Code, item.Description, item.Price, item.Cost, item.ItemType);
            var newCode = _itemRepo.GetByCode(item.Code);
            if (newCode == null) {
                try {
                    await Task.Run(() => { _itemRepo.Add(newItem); });
                    return Ok();
                }
                catch (Exception) {

                }
            }
            return BadRequest("Item code already assigned. Please try again.");


        }

        // PUT api/<ItemsController>/5
        [HttpPut]
        //[Authorize(Roles = "Manager, Staff")]
        public async Task<ActionResult> Put(ItemEditDto item) {
            var dbItem = await Task.Run(() => { return _itemRepo.GetById(item.Id); });
            var newCode = _itemRepo.GetByCode(item.Code);
            if (newCode == null || newCode.Id == item.Id) {
                if (dbItem is null) {
                    return BadRequest($"Item not found");
                }
                dbItem.Code = item.Code;
                dbItem.Description = item.Description;
                dbItem.Cost = item.Cost;
                dbItem.Price = item.Price;
                dbItem.ItemType = item.ItemType;
                try {
                    await Task.Run(() => { _itemRepo.Update(item.Id, dbItem); });
                    return Ok();
                }
                catch (DbUpdateException) {

                }
            }
            return BadRequest("Item code already assigned. Please try again.");
        }

        // DELETE api/<ItemsController>/5
        [HttpDelete("{id}")]
        //[Authorize(Roles = "Manager, Staff")]
        public async Task<ActionResult> Delete(int id) {

            try {
                var result = await Task.Run(() => { return _itemRepo.GetById(id); });

                if (result != null) {
                    if (result.TransactionLines == null || result.TransactionLines.Count == 0) {
                        await Task.Run(() => { _itemRepo.Delete(id); });
                        return Ok();
                    }
                }
                return BadRequest($"Could not delete this Item");
            }
            catch (Exception) {
                return BadRequest($"Could not delete this Item");
            }


        }
    }
}
