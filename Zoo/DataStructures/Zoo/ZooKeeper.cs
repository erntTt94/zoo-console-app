using System;
using System.Collections.Generic;
using System.Text;
using Zoo.DataStructures.Animal;

namespace Zoo.DataStructures.Zoo
{
    public class ZooKeeper
    {

        public string FirstName { get; }
        public string LastName { get; }
        public DateTime StartedWorkOn { get; }

        public bool IsOnDuty { get; set; }

        public List<AnimalType> CanHandleAnimals { get; set; }
        public int WorkExperienceDays { get { return (int)Math.Round((DateTime.UtcNow - StartedWorkOn).TotalDays); } }

        public ZooKeeper(string firstName, string lastName, List<AnimalType> canHandleAnimals, bool isOnDuty = false, DateTime? startedWorkOn = null)
        {
            FirstName = firstName;
            LastName = lastName;
            CanHandleAnimals = canHandleAnimals;
            StartedWorkOn = startedWorkOn ?? DateTime.UtcNow;
            IsOnDuty = isOnDuty;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("-- First Name: ").AppendLine(FirstName);
            sb.Append("-- Last Name: ").AppendLine(LastName);
            sb.Append("-- Work Experience: ").Append(WorkExperienceDays).AppendLine(" days");
            sb.Append("-- Can handle animals: ").AppendLine(string.Join(", ", CanHandleAnimals));

            return sb.ToString();
        }

        public string FeedAnimal(IAnimal animal)
        {
            if (!IsOnDuty)
            {
                return $"{FirstName} is not on duty.";
            }else if (!CanHandleAnimals.Contains(animal.AnimalType))
            {
                return $"{FirstName} cannot handle {animal.AnimalType}s.";
            }else
            {
                return $"{FirstName} feeds {animal.Name}. {animal.Feed()}";
            }
        }

        public string InspectAnimal(IAnimal animal)
        {
            return $"{FirstName} inspects {animal.Name}: " +
           (animal.IsHealthy ? "Healthy" : "Needs attention");
        }

    }
}
