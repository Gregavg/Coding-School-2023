using Session_23.EF.Context;
using Session_23.Model;

namespace Session_23.EF.Repositories {
    public partial class MockCustomerRepo : IEntityRepo<Customer> {
        private readonly List<Customer> _customers;


        public MockCustomerRepo() {
            _customers = new List<Customer> {
            new Customer("Grigoris","Avgenikos","6947000000","143034444") };

        }
        public void Add(Customer entity) {
            using var context = new PetShopDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new PetShopDbContext();
            var dbPetshop = context.Customers.Where(customer => customer.Id == id).SingleOrDefault();
            if (dbPetshop is null)
                return;
            context.Remove(dbPetshop);
            context.SaveChanges();
        }


        public IList<Customer> GetAll() {
            using var context = new PetShopDbContext();
            return _customers;
            //return context.Customers.ToList();
        }

        public Customer? GetById(int id) {
            using var context = new PetShopDbContext();
            return context.Customers.Where(customer => customer.Id == id)
                .SingleOrDefault();
        }

        public void Update(int id, Customer entity) {
            using var context = new PetShopDbContext();
            var dbPetshop = context.Customers.Where(customer => customer.Id == id).SingleOrDefault();
            if (dbPetshop is null)
                return;
            dbPetshop.Name = entity.Name;
            dbPetshop.Surname = entity.Surname;
            dbPetshop.Phone = entity.Phone;
            dbPetshop.Tin = entity.Tin;
            context.SaveChanges();
        }


        public void Clear() {
            using var context = new PetShopDbContext();
            var dbPetshop = context.Customers;

            foreach (var entity in dbPetshop)
                context.Remove(entity);
            context.SaveChanges();
        }


    }
}
    

