using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A",1);
        pq.Enqueue("B",5);
        pq.Enqueue("C",3);

        var result = pq.Dequeue();
        Assert.AreEqual("B", result);
    }

    [TestMethod]
    // Scenario: Add multiple items with the same highest priorty
    // Expected Result: First added item with that priority is removed
    // Defect(s) Found: Fifo nt respected for equal priority
    public void TestPriorityQueue_2()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 5);
        pq.Enqueue("B", 5);
        pq.Enqueue("C", 1);

        var result = pq.Dequeue();

        Assert.AreEqual("A", result);
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Dequeue twice after removing highest priorty
    // Expected Result: Next correct item is returned
    // Defect(s) Found: Item not removed from queue
    public void TestPriorityQueue_3()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 1);
        pq.Enqueue("B", 5);

        pq.Dequeue();
        var result = pq.Dequeue();

        Assert.AreEqual("A", result);
    }

    [TestMethod]
    // Scenario: Dequeue from empty queue
    // Expected Result: InvalidOperationException with correct message
    // Defect(s) Found: Incorrect or missing exception
    public void TestPriorityQueue_4()
    {
        var pq = new PriorityQueue();

        try
        {
            pq.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }

    }
}