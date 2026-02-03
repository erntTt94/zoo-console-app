namespace Zoo.Utilities.Utility
{
    public static class Utility
    {
        public static T? SelectItem<T>(IList<T> list, Func<T, string> displayText)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("No items.");
                return default;
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {displayText(list[i])}");
            }

            Console.Write("Pick number: ");
            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > list.Count)
            {
                Console.WriteLine("Invalid selection.");
                return default;
            }

            return list[choice - 1];
        }
    }
}
