using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.DataStructures.Animal
{
    internal class Monkey : AnimalBase
    {
        public Monkey(string name, int age, bool isHealthy, Gender gender)
            : base(name, age, isHealthy, gender, EnclosureType.Jungle, FoodType.Fruit, AnimalType.Monkey)
        { }

        public override string UniqueBehavior()
        {
            return $"{Name} swings through trees and plays with other monkeys!";
        }

        public override string ToString()
        {
            return GetInfo();
        }
    }
}
