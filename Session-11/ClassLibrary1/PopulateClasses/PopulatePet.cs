using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulateClassLibrary {
    public class PopulatePet {

        public PopulatePet() {

        }

        public List<Pet> PopulatePets() {

            List<Pet> pets = new List<Pet>();

            Pet pet = new Pet("Labrador", AnimalType.Dog, 1500, 1000, PetStatus.OK);
            pets.Add(pet);

            pet = new Pet("Siamese", AnimalType.Cat, 1300, 900, PetStatus.OK);
            pets.Add(pet);

            pet = new Pet("West Highland", AnimalType.Dog, 1000, 700, PetStatus.OK);
            pets.Add(pet);

            pet = new Pet("Parakeet", AnimalType.Parrot, 100, 20, PetStatus.OK);
            pets.Add(pet);

            pet = new Pet("Siamese", AnimalType.Cat, 1300, 900, PetStatus.Recovering); 
            pets.Add(pet);

            pet = new Pet("Sphynx", AnimalType.Cat, 1300, 900, PetStatus.Unhealthy);
            pets.Add(pet);

            pet = new Pet("Himalayan", AnimalType.Cat, 1400, 1000, PetStatus.OK);
            pets.Add(pet);

            pet = new Pet("Malinois", AnimalType.Dog, 1300, 800, PetStatus.Recovering);
            pets.Add(pet);

            pet = new Pet("Macaw", AnimalType.Parrot, 2000, 1200, PetStatus.OK);
            pets.Add(pet);

            pet = new Pet("African Grey", AnimalType.Parrot, 1400, 900, PetStatus.OK);
            pets.Add(pet);

            pet = new Pet("Cockatiel", AnimalType.Parrot, 200, 80, PetStatus.OK);
            pets.Add(pet);

            //bsPet.DataSource = pets
            return pets;


        }

    }
}
