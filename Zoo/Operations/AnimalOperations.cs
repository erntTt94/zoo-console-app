using Zoo.DataStructures.Animal;
using Zoo.DataStructures.Zoo;
using Zoo.Utilities.Utility;

namespace Zoo.Operations.AnimalOperations
{
    internal static class AnimalOperations
    {
        public static void DemoAddZooAnimals(Zoo zoo)
        {
            zoo.AddAnimal(AnimalFactory.CreateWolf("Lon", 3, true, Gender.Male));
            zoo.AddAnimal(AnimalFactory.CreateLion("Mo", 6, false, Gender.Male));
            zoo.AddAnimal(AnimalFactory.CreateBear("Padington", 2, true, Gender.Female));

        }
        public static void DemoPrintAnimals(IEnumerable<IAnimal> animals)
        {
            Console.WriteLine();
            Console.WriteLine("---- Animals List -----");
            foreach (var animal in animals)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine(animal);
            }
            Console.ReadLine();
        }
        public static void DemoUpdateAnimal(Zoo zoo)
        {
            var animal = Utility.SelectItem(zoo.CurrentAnimals, k => $"{k.Name} ({k.AnimalType})");
            if (animal == null) return;

            Console.Write($"Animal age: [Current age: {animal.Age}]: ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int age))
            {
                animal.Age = age;
            }
            Console.Write("Is it healthy? ");
            input = Console.ReadLine();
            if (bool.TryParse(input, out bool isHealthy))
            {
                animal.IsHealthy = isHealthy;
            }
            Console.WriteLine("Animal updated.");
            Console.ReadLine();
        }
        public static void DemoFeedAnimal(Zoo zoo)
        {
            HandleAnimal(zoo, (keeper, animal) => keeper.FeedAnimal(animal), "feed");
            Console.ReadLine();
        }
        public static void DemoInspectAnimal(Zoo zoo)
        {
            HandleAnimal(zoo, (keeper, animal) => keeper.InspectAnimal(animal), "inspect");
            Console.ReadLine();

        }
        public static void DemoRemoveAnimal(Zoo zoo)
        {
            Console.WriteLine("Animals:");
            var animal = Utility.SelectItem(zoo.CurrentAnimals, k => $"{k.Name} ({k.AnimalType})");
            if (animal == null) return;
            zoo.DeleteAnimal(animal);
            Console.WriteLine("Animal removed.");
            Console.ReadLine();
        }
        public static void DemoAnimalBehavior(Zoo zoo)
        {
            var animal = Utility.SelectItem(zoo.CurrentAnimals, k => $"{k.Name} ({k.AnimalType})");
            if (animal == null) return;
            Console.WriteLine(animal.UniqueBehavior());
            Console.ReadLine();
        }
        private static void HandleAnimal(Zoo zoo, Func<ZooKeeper, IAnimal, string> action, string actionName)
        {
            var animal = Utility.SelectItem(zoo.CurrentAnimals, k => $"{k.Name} ({k.AnimalType})");
            if (animal == null) return;

            var keeper = zoo.ZooKeepers.FirstOrDefault(k => k.IsOnDuty && k.CanHandleAnimals.Contains(animal.AnimalType));

            Console.WriteLine(keeper == null ? $"No keeper available to {actionName} this animal." : action(keeper, animal));
        }
    }
}
