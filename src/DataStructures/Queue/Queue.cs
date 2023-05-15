namespace DataStructures
{
  class QueueNode<T>
  {
    public T Value;
    public QueueNode<T>? Next;

    public QueueNode(T value)
    {
      Value = value;
      Next = null;
    }
  }

  class Queue<T>
  {
    private QueueNode<T>? front;
    private QueueNode<T>? back;

    public Queue()
    {
      front = null;
      back = null;
    }

    public void Push(T value)
    {
      QueueNode<T> newNode = new QueueNode<T>( value);

      if (front == null)
      {
        front = newNode;
        back = newNode;
      }
      else
      {
        // 
        back!.Next = newNode;
        back = back.Next;
      }
    }

    public T? Pop()
    {
      // If the list is empty just return null
      if (front == null)
      {
        return default(T);
      }

      // Grab the first item
      QueueNode<T> frontNode = front;

      // Move the queue forward
      front = frontNode.Next;

      // If no front item queue is empty update back as well
      if (front == null)
      {
        back = null;
      }

      // Return the value we got
      return frontNode.Value;
    }

    public T? Peak()
    {
      // If the list is empty just return null
      if (front == null)
      {
        return default(T);
      }

      // Just return the value of the front of the queue
      return front.Value;
    }
  }

  class QueueTest
  {
    public static void Run()
    {
      // Instantiate class
      Queue<string> queue = new Queue<string>();

      System.Console.WriteLine("A newly initialized queue should display the default null type for strings");
      System.Console.WriteLine(queue.Pop());

      // Add items to queue
      queue.Push("Foo 1");
      queue.Push("Bar 2");
      queue.Push("Fizz 3");
      queue.Push("Buzz 4");

      System.Console.WriteLine("Peak should return 'Foo 1'");
      System.Console.WriteLine(queue.Peak());

      System.Console.WriteLine("Pop should also return 'Foo 1'");
      System.Console.WriteLine(queue.Pop());
      
      System.Console.WriteLine("Second pop should return 'Bar 2'");
      System.Console.WriteLine(queue.Pop());

      System.Console.WriteLine("Peak should now return 'Fizz 3'");
      System.Console.WriteLine(queue.Peak());

      // Create a new queue for numbers
      Queue<int> numberQueue = new Queue<int>();

      // Push a bunch of numbers into the queue
      for (int i = 0; i < 20; i++)
      {
        numberQueue.Push(i);
      }

      // Pop all the items from the queue
      for (int i = 0; i < 20; i++)
      {
        System.Console.WriteLine(numberQueue.Pop());
      }

      // Last test here ensure poping from an empty list returns null
      System.Console.WriteLine("This queue should be empty now and display the default null type for integers");
      System.Console.WriteLine(numberQueue.Pop());
    }
  }
}