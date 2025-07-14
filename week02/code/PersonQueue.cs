/// <summary>
/// A basic implementation of a Queue
/// </summary>
public class PersonQueue
{
    private readonly List<Person> _list = new();

    public int Length => _list.Count;
    public bool IsEmpty() => _list.Count == 0;

    public void Enqueue(Person person)
    {
        _list.Add(person); // Add to the end
    }

    public Person Dequeue()
    {
        if (_list.Count == 0)
            throw new InvalidOperationException("No one in the queue.");
        var person = _list[0]; // Remove from the front
        _list.RemoveAt(0);
        return person;
    }

    public override string ToString()
    {
        return string.Join(", ", _list.Select(p => p.Name));
    }
}