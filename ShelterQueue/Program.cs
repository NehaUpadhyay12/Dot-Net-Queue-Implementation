using System;
using System.Collections.Generic;

namespace ShelterQueue
{
    class Animal
    {
        public string name;
        public string typeOfAnimal;
        public Animal(string name, string typeOfAnimal)
        {
            this.name = name;
            this.typeOfAnimal = typeOfAnimal;
        }
    }

    class AnimalShelter
    {
        LinkedList<Animal> animals;

        public AnimalShelter()
        {
            animals = new LinkedList<Animal>();
        }

        public void Enqueue(Animal animal)
        {
            animals.AddLast(animal);
        }

        public Animal DequeueAny()
        {
            Animal animal = animals.First.Value;
            animals.RemoveFirst();
            return animal;
        }

        public Animal DequeueDog()
        {
            Animal retVal=null;
            foreach (var item in animals)
            {
                if(item.typeOfAnimal == "Dog")
                {
                    retVal = item;
                    animals.Remove(item);
                    break;
                }
            }
            return retVal;
        }

        public Animal DequeueCat()
        {
            Animal retVal = null;
            foreach (var item in animals)
            {
                if (item.typeOfAnimal == "Cat")
                {
                    retVal = item;
                    animals.Remove(item);
                    break;
                }
            }
            return retVal;
        }

    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            AnimalShelter obj = new AnimalShelter();
            obj.Enqueue(new Animal("Cat1", "Cat"));
            obj.Enqueue(new Animal("Dog1", "Dog"));
            obj.Enqueue(new Animal("Cat2", "Cat"));
            obj.Enqueue(new Animal("Dog2", "Dog"));
            obj.Enqueue(new Animal("Cat3", "Cat"));
            obj.Enqueue(new Animal("Cat4", "Cat"));
            obj.Enqueue(new Animal("Dog3", "Dog"));
            obj.Enqueue(new Animal("Cat5", "Cat"));

            Animal anyAnimal = obj.DequeueAny();
            Console.WriteLine($"You are adopting a {anyAnimal.typeOfAnimal} named {anyAnimal.name}");

            Animal animalCat = obj.DequeueCat();
            Console.WriteLine($"You are adopting a Cat named {animalCat.name}");

            Animal anyAnimal1 = obj.DequeueAny();
            Console.WriteLine($"You are adopting a {anyAnimal1.typeOfAnimal} named {anyAnimal1.name}");

            obj.Enqueue(new Animal("Dog4", "Dog"));

            Animal anyAnimal2 = obj.DequeueAny();
            Console.WriteLine($"You are adopting a {anyAnimal2.typeOfAnimal} named {anyAnimal2.name}");

            Animal animalDog = obj.DequeueDog();
            Console.WriteLine($"You are adopting a Dog named {animalDog.name}");

            Animal animalDog1 = obj.DequeueDog();
            Console.WriteLine($"You are adopting a Dog named {animalDog1.name}");
        }
    }
}
