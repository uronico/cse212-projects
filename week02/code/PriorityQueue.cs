public class PriorityQueue
{
    private class Item
    {
        public string Value { get; }
        public int Priority { get; }
        public Item(string value, int priority)
        {
            Value = value;
            Priority = priority;
        }
    }

    private readonly List<Item> _items = new();

    public void Enqueue(string value, int priority)
    {
        _items.Add(new Item(value, priority));
    }

    public string Dequeue()
    {
        if (_items.Count == 0)
            throw new InvalidOperationException("Queue is empty.");

        // Find the highest priority
        int maxPriority = _items.Max(i => i.Priority);

        // Find the first item with the highest priority (FIFO)
        int index = _items.FindIndex(i => i.Priority == maxPriority);
        string result = _items[index].Value;
        _items.RemoveAt(index);
        return result;
    }
}