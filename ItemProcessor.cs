namespace lab10
{
    class ItemProcessor
    {
        public delegate int ComparisonDelegate(Item item1, Item item2);

        public static void SortItems(Item[] items, ComparisonDelegate comparison)
        {
            if (items != null && items.Length > 0)
            {
                Array.Sort(items, new Comparison<Item>(comparison));
            }
            else
            {
                Console.WriteLine("Нет элементов для сортировки.");
            }
        }

        public static Item[] FilterItems(Item[] items, Predicate<Item> predicate)
        {
            return Array.FindAll(items, predicate);
        }
    }
}
