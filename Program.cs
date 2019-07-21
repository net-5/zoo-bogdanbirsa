
// Model a ZOO keeping in mind that:
// A zoo has a name and a list of animals
// At a zoo they can bring new animals and transfer animals to new zoos
// At a zoo the animals are daily fed with their favorite food, and each animal eats what it loves to eat.
// Each animal knows to eat by itself, and not all animals of the same type prefer the same type of food.Eg; a horse prefers carrots, and another horse prefers apples
namespace ZooHomeWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            Zoo newZoo = new Zoo("Zoo IASI");
            newZoo.AllAnimals();

            var cal = new Cal("cal", AnimalFood.Iarba);
            newZoo.AddAnimal(cal);
            newZoo.AddAnimal(new Maimuta("maimuta", AnimalFood.Banane));
            newZoo.AddAnimal(new Iepure("iepure", AnimalFood.Morcovi));

            newZoo.AllAnimals();
            newZoo.RemoveAnimal(cal);
            newZoo.AllAnimals();

            newZoo.FeedAnimals();
        }
    }
}
