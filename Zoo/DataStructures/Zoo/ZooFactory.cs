using System;
using Zoo.DataStructures.Animal;
using Zoo.DataStructures.Zoo;

namespace Zoo
{
    public static class ZooFactory
    {
        public static ZooKeeper CreateZooKeeper(string firstName, string lastName, List<AnimalType> canHandleAnimals, bool isOnDuty = false, DateTime? startedWorkOn = null)
        {
            return new ZooKeeper(firstName, lastName,canHandleAnimals,isOnDuty, startedWorkOn);
        }

        public static Zoo CreateZoo(string name)
        {
            return new Zoo(name);
        }
    }
}
