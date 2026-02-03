using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.DataStructures.Animal
{
    internal class Bird : AnimalBase
    {

        public Bird(string name, int age, bool isHealthy, Gender gender)
            : base(name, age, isHealthy, gender, EnclosureType.Aviary, FoodType.Fruit, AnimalType.Bird)
        { }

        public override string UniqueBehavior()
        {
            return $"{Name} flaps wings and sings a beautiful song!";
        }

        public override string ToString()
        {
            return GetInfo();
        }
    }
}
