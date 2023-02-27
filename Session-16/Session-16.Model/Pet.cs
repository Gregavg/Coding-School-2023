using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Model {
    public class Pet {
        public AnimalType? Animaltype { get; set; }

        public PetStatus Petstatus { get; set; }

        public Guid ID { get; set; }

        public string? Breed { get; set; }

        public decimal Price { get; set; }

        public decimal Cost { get; set; }

        public DateTime Bought { get; set; }

        public Guid? TransactionID { get; set; }

        public Transaction? transaction;

        public Pet() {
            ID = Guid.NewGuid();
            //DateTime dt = new DateTime(1990, 1, 1);
            //Bought = dt;
            //TransactionID = null;
        }

        ////not in transaction
        //public Pet(string breed, AnimalType? animaltype, decimal price, decimal cost, DateTime bought, PetStatus petstatus) {
        //    ID = Guid.NewGuid();
        //    Bought = bought;
        //    Animaltype = animaltype;
        //    //TransactionID = Guid.Empty;
        //    Price = price;
        //    Cost = cost;
        //    Petstatus = petstatus;
        //    Breed = breed;
        //}
        ////without datetime
        //public Pet(string breed, AnimalType? animaltype, decimal price, decimal cost, PetStatus petstatus) {
        //    ID = Guid.NewGuid();
        //    Animaltype = animaltype;
        //    //TransactionID = Guid.Empty;
        //    Price = price;
        //    Cost = cost;
        //    Petstatus = petstatus;
        //    Breed = breed;
        //}

        ////in transaction
        //public Pet(string breed, AnimalType? animaltype, decimal price, decimal cost, DateTime bought, Guid transactionID, PetStatus petstatus) {
        //    ID = Guid.NewGuid();
        //    Bought = bought;
        //    Animaltype = animaltype;
        //    //TransactionID = transactionID;
        //    Price = price;
        //    Cost = cost;
        //    Breed = breed;
        //    Petstatus = petstatus;
        //}
        ////without datetime
        //public Pet(string breed, AnimalType? animaltype, decimal price, decimal cost, Guid transactionID, PetStatus petstatus) {
        //    ID = Guid.NewGuid();
        //    Animaltype = animaltype;
        //    //TransactionID = transactionID;
        //    Price = price;
        //    Cost = cost;
        //    Petstatus = petstatus;
        //    Breed = breed;
        //}



        //public void SetTransactionID(Guid transactionID) {
        //    TransactionID = transactionID;
        //}
        //}




    }
}
