using System;
using System.Collections.Generic;

/*Model a ZOO keeping in mind that:
A zoo has a name and a list of animals
At a zoo they can bring new animals and transfer animals to new zoos
At a zoo the animals are daily fed with their favorite food, and each animal eats what it loves to eat.
Each animal knows to eat by itself, and not all animals of the same type prefer the same type of food. Eg; a horse prefers carrots, and another horse prefers apples*/
class Zoo

{
    public string NameOfZoo;
    public Dictionary<string, string> animalsList = new Dictionary<string, string>();
    public static string NameOfAnimal;
    public string FavoriteFood;
    public static int NrOfAnimals;
    
    public class Program
    {
        public static void Main()
        {
            Zoo Zoo = new Zoo("GRADINA ZOOLOGICA");
            Zoo.AddAnimal("leul", "carne cruda");
            Zoo.AddAnimal("vulpea", "gaini");
            Zoo.AddAnimal("caprioara", "iarba");
            Zoo.AddAnimal("iepurele", "morcovi");
            Zoo.AddAnimal("maimutele", "banane");
            Zoo.AddAnimal("soarecii", "branza");
            Zoo.PresentZoo();
            Zoo.Transfer("maimutele");
            Zoo.PresentZoo();

        }
    }
    public Zoo(string name)
    {
        this.NameOfZoo = name;
    }

    public Dictionary<string, string> AnimalsList //
    {
        get { return this.animalsList; }
    }

    public void Eat() { }

    static void AddAnimal()
    {
        NameOfAnimal = "";
        NrOfAnimals = 0;
    }

    public void AddAnimal(string name, string food) //adaugam animale
    {
        NameOfAnimal = name;
        this.FavoriteFood = food;
        NrOfAnimals++;
        this.animalsList.Add(name, food);
    }

    public static int GetNrOfAnimals() //aflam nr de animale
    {
        return NrOfAnimals;
    }

    public void Transfer(string animal) //transferam animale
    {
        if (this.AnimalsList.ContainsKey(animal))
        {
            Console.Write(this.AnimalsList.Remove(animal));
            NrOfAnimals--;
        }
        else
        {
            Console.WriteLine("We don't have this animal in our garden.");
        }
    }
    public void PresentZoo()
    {
        int num = 1;
        Console.WriteLine("In " + this.NameOfZoo + " sunt " + NrOfAnimals + " animale dupa cum urmeaza: ");
        foreach (var animal in this.AnimalsList)
        {
            Console.WriteLine(num + ". " + animal.Key + ", mananca " + animal.Value);
            num++;
        }
    }
}