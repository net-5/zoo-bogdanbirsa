using System;
using System.Collections.Generic;
using System.Text;

namespace ZooHomeWork
{
    public class Zoo
    {
        public Zoo(string name)
        {
            this.name = name;
        }

        public List<Animal> animallist = new List<Animal>();
        public string name;
        public void AllAnimals()
        {
            if (animallist.Count == 0)
            {
                Console.WriteLine($"Initial nu sunt animale in {name}.");
                return;
            }

            StringBuilder listOfAnimals = new StringBuilder();

            foreach (var animal in animallist)
            {
                listOfAnimals.Append(animal.Name + ", ");
            }

            string listOfAnimalsTemp = listOfAnimals.ToString().Substring(0, listOfAnimals.Length - 2);

            Console.WriteLine($"{name} are urmatoarele animale: {listOfAnimalsTemp}.");
        }

        public void AddAnimal(Animal animal)
        {
            animallist.Add(animal);
            Console.WriteLine($"{animal.Name} adaugat(a).");
        }

        public void RemoveAnimal(Animal animal)
        {
            animallist.Remove(animal);
            Console.WriteLine($"{animal.Name} eliminat(a).");
        }

        public void FeedAnimals()
        {
            foreach (var animal in animallist)
            {
                animal.Eat();
            }
        }
    }
}
