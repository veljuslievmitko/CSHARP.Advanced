

using SEDC.Homework.Generic.Domain.Models;
using SEDC.Homework.Generic.Domain.NewFolder;

List<Dog> dogsList = new List<Dog>()
{
    new Dog("Sparky", 5, "chiken"), 
    new Dog("Boby", 4, "beef"),
    new Dog("jacky", 10, "everything")
};
List<Cat> catList = new List<Cat>()
{
    new Cat("Garfiled", 3, true),
    new Cat("Maza0", 6, false),
    new Cat("Garfiled3", 30, true),
};
List<Fish> fishList = new List<Fish>()
{
    new Fish("fisi1", 4, "blue", 5),
    new Fish("fisi2", 20, "red", 10),
    new Fish("fisi3", 30, "blue", 15),
};

Petstore<Cat> catStore = new Petstore<Cat>();
catStore.AddList(catList);
catStore.PrintPets();

Petstore<Dog> dogStore = new Petstore<Dog>();

dogStore.AddList(dogsList);
dogStore.PrintPets();

dogStore.BuyPet("Sparky");
Helper.Lines();
