using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.DataStructures.Animal
{
    public enum AnimalType
    {
        Lion,
        Monkey,
        Bear,
        Bird,
        Elephant,
        Wolf
    }

    public enum FoodType
    {
        Vegetable,
        Meat,
        Fruit
    }

    public enum Gender
    {
        Male,
        Female
    }

    public enum EnclosureType
    {
        Aviary,
        Jungle,
        Savannah
    }

    public interface IAnimal
    {
        string Name { get; }
        int Age { get; set; }
        bool IsHealthy { get; set; }

        Gender Gender  { get; }

        EnclosureType EnclosureType { get; }
        FoodType FoodType { get; }

        AnimalType AnimalType { get; }


        string GetInfo();

        string Feed();
        string UniqueBehavior();



    }
}


