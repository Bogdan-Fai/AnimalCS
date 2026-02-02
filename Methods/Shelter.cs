using System;
using System.Collections.Generic;

namespace AnimalsCS
{
    // Shelter class
    public class Shelter
    {
        private List<Animal> animals;

        public Shelter()
        {
            animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void MakeAllSounds()
        {
            foreach (var animal in animals)
            {
                animal.MakeSound();
            }
        }

        public void MoveAllAnimals()
        {
            foreach (var animal in animals)
            {
                animal.Move();
            }
        }
    }
}
