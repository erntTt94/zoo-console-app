using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.DataStructures.Animal
{
    internal class Elephant : AnimalBase
    {
        public Elephant(string name, int age, bool isHealthy, Gender gender)
            : base(name, age, isHealthy, gender, EnclosureType.Savannah, FoodType.Vegetable,AnimalType.Elephant)
        { }

        public override string UniqueBehavior()
        {
            return $"{Name} uses its trunk to spray water.";
        }

        public override string ToString()
        {
            return GetInfo();
        }
    }
}
