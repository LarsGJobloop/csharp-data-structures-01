// Namespaces are a way to group similiar or related classes
// If you want to access these classes outside this file
// you would write "<namespace>.<className>"
// For our LinkedListBasic that would be
// "DataStructures.LinkedListBasic"
namespace DataStructures
{
    // The "data" container
    // Stores the value of the node
    // and a pointer to the next node in the list
    // unless it is the last, then the pointer is null
    public class LinkedListBasicNode
    {
        public string Value;
        public LinkedListBasicNode? Next;

        // This is the constructor method
        // that will be called whenever we are
        // appending to our list.
        // Since this will then become the last element
        // The Next member will not point to anything
        public LinkedListBasicNode(string value)
        {
            Value = value;
            Next = null;
        }
    }

    // The class containing the members (data) and methods (functionality)
    // for our Linked List implementation
    public class LinkedListBasic
    {
        // We are only storing the first element of the list here
        // And then we are using this to traverse the list
        private LinkedListBasicNode? Head;

        // When we initialy create the list,
        // It will be empty, hence us setting Head to null here
        public LinkedListBasic()
        {
            Head = null;
        }

        // A method for appending an element to the
        // end of our list, you might use a similar construct
        // for removing elements from our list
        public void Append(string value)
        {
            // Here we are creating a new node from the
            // arguments passed to this method
            LinkedListBasicNode newNode = new LinkedListBasicNode(value);

            // There are two cases here
            // 1. The list has just been created and does not contain any elements
            if (Head == null)
            {
                Head = newNode;
            }
            // 2. We have elements in the list and need to append the new node to the end
            else
            {
                // Remember the current node we are checking
                LinkedListBasicNode current = Head;

                // Walk through the list until we find the last node
                while (current.Next != null)
                {
                    current = current.Next;
                }

                // Append the new node to the end
                current.Next = newNode;
            }
        }

        // A method for logging all the elements
        // of the list to the console
        public void PrintAll()
        {
            // We are using the same traversal method here to
            // walk through all the nodes in our list
            // starting from the beginning (Head)
            LinkedListBasicNode? current = Head;

            while (current != null)
            {
                System.Console.WriteLine($"Value of Node: {current.Value}");
                current = current.Next;
            }
        }
    }

    // A convenience class for testing our Linked List
    public class LinkedListBasicTest
    {
        // The static keyword is related to how classes are created
        // In this case we are only using it to avoid having to create
        // an instance of the LinkedListBasicTest class, before
        // running the .Run() method
        static public void Run()
        {
            // Create an instance of the class
            LinkedListBasic list = new LinkedListBasic();

            System.Console.WriteLine("\nExpecting this to print an empty list");
            list.PrintAll();

            System.Console.WriteLine("\nAdding a single element to the list");
            list.Append("Hello World");
            list.PrintAll();

            System.Console.WriteLine("\nAdding a another element to the list");
            list.Append("Fizzbuzz");
            list.PrintAll();

            System.Console.WriteLine("\nMultiple elements added");
            list.Append("Foo");
            list.Append("Bar");
            list.Append("Bizz");
            list.Append("Buzz");
            list.Append("42");
            list.Append("Many");
            list.PrintAll();
        }
    }
}