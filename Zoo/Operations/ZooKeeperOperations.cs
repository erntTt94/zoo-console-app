using Zoo.DataStructures.Animal;
using Zoo.DataStructures.Zoo;
using Zoo.Utilities.Utility;

namespace Zoo.Operations.ZooKeeperOperations
{
    internal static class ZooKeeperOperations
    {
        public static void DemoAddZooKeepers(Zoo zoo)
        {
            zoo.AddZooKeeper(ZooFactory.CreateZooKeeper("John", "Don", new List<AnimalType> { AnimalType.Elephant, AnimalType.Bird }, true, new DateTime(2025, 5, 3)));
            zoo.AddZooKeeper(ZooFactory.CreateZooKeeper("Patrick", "Garsia", new List<AnimalType> { AnimalType.Bear, AnimalType.Wolf, AnimalType.Lion }, true, new DateTime(2021, 2, 3)));
            zoo.AddZooKeeper(ZooFactory.CreateZooKeeper("Ivan", "Ivanov", new List<AnimalType> { AnimalType.Monkey }, true, new DateTime(2024, 7, 5)));
        }
        public static void DemoPrintZooInfo(Zoo zoo)
        {
            Console.WriteLine();
            Console.WriteLine(zoo.GetBasicInfo());
            Console.WriteLine("---- Zoo Keepers List -----");
            foreach (var zk in zoo.ZooKeepers)
            {
                Console.WriteLine("- Zoo Keeper Info: ");
                Console.WriteLine(zk);
            }
            Console.ReadLine();
        }
        public static void DemoRemoveZooKeeper(Zoo zoo)
        {
            Console.WriteLine("Zoo Keepers:");
            var keeper = Utility.SelectItem(zoo.ZooKeepers, k => $"{k.FirstName} {k.LastName}");
            if (keeper == null) return;
            zoo.DeleteZooKeeper(keeper);
            Console.WriteLine("ZooKeeper removed.");
            Console.ReadLine();
        }
        public static void DemoUpdateZooKeeper(Zoo zoo)
        {
            var keeper = Utility.SelectItem(zoo.ZooKeepers, k => $"{k.FirstName} {k.LastName}");
            if (keeper == null) return;

            Console.Write($"IsOnDuty (true/false) [{keeper.IsOnDuty}]: ");
            var input = Console.ReadLine();
            if (bool.TryParse(input, out bool isOnDuty))
            {
                keeper.IsOnDuty = isOnDuty;
            }

            Console.Write("Add new animal that keeper can handle: ");
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && Enum.TryParse<AnimalType>(input.Trim(), true, out var at))
            {
                if (!keeper.CanHandleAnimals.Contains(at))
                    keeper.CanHandleAnimals.Add(at);
                else
                    Console.WriteLine($"{at} already present.");
            }

            Console.WriteLine("ZooKeeper updated.");
            Console.ReadLine();
        }
    }
}
