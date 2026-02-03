using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.DataStructures.Animal
{
    internal class Bear : AnimalBase
    {
        public Bear(string name, int age, bool isHealthy, Gender gender)
            : base(name, age, isHealthy, gender, EnclosureType.Jungle, FoodType.Meat, AnimalType.Bear)
        { }

        public override string Feed()
        {
            string baseResult = base.Feed();
            return baseResult + " (Bear can also eat fruits!)";
        }
        public override string UniqueBehavior()
        {
            return $"{Name} climbs tree to play!";
        }

        public override string ToString()
        {
            return GetInfo();
        }
    }
}
