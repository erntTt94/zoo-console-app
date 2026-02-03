using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.DataStructures.Animal
{
    internal class Lion : AnimalBase
    {
        public Lion(string name, int age, bool isHealthy, Gender gender)
            : base(name,age,isHealthy, gender,EnclosureType.Savannah,FoodType.Meat, AnimalType.Lion)
        { }

        public override string UniqueBehavior()
        {
            return $"{Name} roars loudly to mark its territory!";
        }

        public override string ToString()
        {
            return GetInfo();
        }
    }
}
