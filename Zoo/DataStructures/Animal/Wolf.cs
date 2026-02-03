using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.DataStructures.Animal
{
    internal class Wolf : AnimalBase
    {
        public Wolf(string name, int age, bool isHealthy, Gender gender)
            : base(name, age, isHealthy, gender, EnclosureType.Savannah, FoodType.Meat,AnimalType.Wolf)
        { }

        public override string UniqueBehavior()
        {
            return $"{Name} howls at the moon and patrols its pack!";
        }

        public override string ToString()
        {
            return GetInfo();
        }
    }
}
