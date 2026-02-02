using System;

namespace AnimalsCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Shelter shelter = new Shelter();

            try
            {
                Dog dog = new Dog("Buddy");
                Cat cat = new Cat("Whiskers");

                shelter.AddAnimal(dog);
                shelter.AddAnimal(cat);

                shelter.MakeAllSounds();
                shelter.MoveAllAnimals();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
