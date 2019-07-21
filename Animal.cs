using System;

namespace ZooHomeWork
{
    public enum AnimalFood { Morcovi, Mere, Iarba, Banane }

    public class Animal
    {
        public string name;
        public AnimalFood preferredFood;

        public Animal(string name, AnimalFood animalFood)
        {
            this.name = name;
            this.preferredFood = animalFood;
        }

        public string Name => name;

        public void Eat()
        {
            Console.WriteLine($"{GetType().Name} mananca {preferredFood}.");
        }
        public class Cal : Animal
        {
            public Cal(string name, AnimalFood animalFood) : base(name, animalFood)
            {
            }
        }
        public class Iepure : Cal
        {
            public Iepure(string name, AnimalFood animalFood) : base(name, animalFood)
            {
            }
        }

        public class Maimuta : Iepure
        {
            public Maimuta(string name, AnimalFood animalFood) : base(name, animalFood)
            {
            }
        }
    }
    public class Cal : Animal
    {
        public Cal(string name, AnimalFood animalFood) : base(name, animalFood)
        {
        }
    }
    public class Iepure : Cal
    {
        public Iepure(string name, AnimalFood animalFood) : base(name, animalFood)
        {
        }
    }

    public class Maimuta : Iepure
    {
        public Maimuta(string name, AnimalFood animalFood) : base(name, animalFood)
        {
        }
    }
}
