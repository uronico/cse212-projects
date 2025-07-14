using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue one item and dequeue it.
    // Expected Result: The item is returned.
    // Defect(s) Found: Test not implemented.
    public void TestPriorityQueue_1()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("X", 5);
        Assert.AreEqual("X", pq.Dequeue()); // Already changed the codes so it will passed.
    }

    [TestMethod]
    // Scenario: Enqueue two items with different priorities, dequeue twice.
    // Expected Result: Highest priority item is returned first, then the other.
    // Defect(s) Found: Test not implemented.
    public void TestPriorityQueue_2()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 1);
        pq.Enqueue("B", 2);
        Assert.AreEqual("B", pq.Dequeue());
        Assert.AreEqual("A", pq.Dequeue()); // Already changed the codes so it will passed.
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Enqueue three items with different priorities, then dequeue all.
    // Expected Result: Items are dequeued in order of highest priority first.
    // Defect(s) Found: Queue is not properly identifying the highest priority item.
    public void TestPriorityQueue_DequeueHighestPriority()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 1);
        pq.Enqueue("B", 3);
        pq.Enqueue("C", 2);

        Assert.AreEqual("B", pq.Dequeue()); // Highest priority
        Assert.AreEqual("C", pq.Dequeue()); // Next highest
        Assert.AreEqual("A", pq.Dequeue()); // Lowest
    }

    [TestMethod]
    // Scenario: Enqueue items with the same priority, then dequeue.
    // Expected Result: Items with same priority are dequeued in FIFO order.
    // Defect(s) Found: The queue violates FIFO order among items with tied priorities.
    public void TestPriorityQueue_FifoOnTie()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 2);
        pq.Enqueue("B", 2);
        pq.Enqueue("C", 2);

        Assert.AreEqual("A", pq.Dequeue());
        Assert.AreEqual("B", pq.Dequeue());
        Assert.AreEqual("C", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue.
    // Expected Result: Exception is thrown.
    // Defect(s) Found: No defect found, but this test ensures that the queue handles empty states correctly.
    public void TestPriorityQueue_EmptyDequeue()
    {
        var pq = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => pq.Dequeue());
    }
}