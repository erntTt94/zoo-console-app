using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.DataStructures.Animal
{
    public static class AnimalFactory
    {
        public static IAnimal CreateLion(string name, int age, bool isHealthy, Gender gender)
        {
            return new Lion(name, age, isHealthy, gender);
        }

        public static IAnimal CreateMonkey(string name, int age, bool isHealthy, Gender gender)
        {
            return new Monkey(name, age, isHealthy, gender);
        }

        public static IAnimal CreateWolf(string name, int age, bool isHealthy, Gender gender)
        {
            return new Wolf(name, age, isHealthy, gender);
        }

        public static IAnimal CreateElephant(string name, int age, bool isHealthy, Gender gender)
        {
            return new Elephant(name, age, isHealthy, gender);
        }

        public static IAnimal CreateBird(string name, int age, bool isHealthy, Gender gender)
        {
            return new Bird(name, age, isHealthy, gender);
        }

        public static IAnimal CreateBear(string name, int age, bool isHealthy, Gender gender)
        {
            return new Bear(name, age, isHealthy, gender);
        }
    }
}
