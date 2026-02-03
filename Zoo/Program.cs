
using Zoo.DataStructures.Zoo;
using static Zoo.Operations.ZooKeeperOperations.ZooKeeperOperations;
using static Zoo.Operations.AnimalOperations.AnimalOperations;

namespace Zoo
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var zoo = ZooFactory.CreateZoo("Laipzig");

            DemoAddZooKeepers(zoo);
            DemoAddZooAnimals(zoo);

            RunMenu(zoo);
        }

           private static void RunMenu(Zoo zoo)
        {
            bool exit = false;
            
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("===== ZOO MENU =====");
                Console.WriteLine("1. Show Zoo Info And Zoo Keepers.");
                Console.WriteLine("2. Show Animals.");
                Console.WriteLine("3. Feed Animal.");
                Console.WriteLine("4. Inspect Animal.");
                Console.WriteLine("5. Animal Unique Behavior");
                Console.WriteLine("6. Remove Zoo Keeper");
                Console.WriteLine("7. Remove Animal");
                Console.WriteLine("8. Update Zoo Keeper");
                Console.WriteLine("9. Update Animal");
                Console.WriteLine("0. Exit");
                Console.Write("Choose option: ");
                

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        DemoPrintZooInfo(zoo);
                        break;

                    case "2":
                        DemoPrintAnimals(zoo.CurrentAnimals);
                        break;

                    case "3":
                        DemoFeedAnimal(zoo);
                        break;

                    case "4":
                        DemoInspectAnimal(zoo);
                        break;

                    case "5":
                        DemoAnimalBehavior(zoo);
                        break;

                    case "6":
                        DemoRemoveZooKeeper(zoo);
                        break;

                    case "7":
                        DemoRemoveAnimal(zoo);
                        break;

                    case "8":
                        DemoUpdateZooKeeper(zoo);
                        break;

                    case "9":
                        DemoUpdateAnimal(zoo);
                        break;

                    case "0":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
