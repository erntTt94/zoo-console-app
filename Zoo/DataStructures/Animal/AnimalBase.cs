using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace Zoo.DataStructures.Animal
{
    public abstract class AnimalBase : IAnimal 
    {
        public string Name { get; }
        public int Age { get; set; }
        public bool IsHealthy { get; set; }
        public Gender Gender { get; }
        public EnclosureType EnclosureType { get; }
        public FoodType FoodType { get; }
        public AnimalType AnimalType { get; }


        protected AnimalBase(string name, int age, bool isHealthy, Gender gender, EnclosureType enclosureType, FoodType foodType, AnimalType animalType)
        {
            Name = name;
            Age = age;
            IsHealthy = isHealthy;
            Gender = gender;
            EnclosureType = enclosureType;
            FoodType = foodType;
            AnimalType = animalType;
        }

        public virtual string GetInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Animals Information: ");
            sb.Append("---Type: ").AppendLine(AnimalType.ToString());
            sb.Append("---Name: ").AppendLine(Name);
            sb.Append("---Age: ").AppendLine(Age.ToString());
            sb.Append("---Healthy: ").AppendLine(IsHealthy.ToString());
            sb.Append("---Enclosure Type: ").AppendLine(EnclosureType.ToString());
            sb.Append("---Food Type: ").AppendLine(FoodType.ToString());
            return sb.ToString();
        }

       public virtual string Feed()
        {
            IsHealthy = true;
            return $"{Name} happily eats {FoodType}.";
        }

        public abstract string UniqueBehavior();


    }
}
