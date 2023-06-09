// This example here makes use of what is called
// generic types
// Instead of creating a Linked List class for all the various
// types this accepts a type as an argument when you are
// creating an instance of the class

// Non generic example:
// LinkedList list = new LinkedList();

// Generic example:
// LinkedList<string> = new LinkedList<string>();

// Note the extra parameter in the second example
// we are passing in a type as a parameter, in this case a string

// This avoids a lot of code duplication

// If you look at the code below you will see that
// there is quite a lot of <T> and "T" there
// The "T" are placed where you normally would use a 
// concrete type like string, int, boolean, etc
// While the <T> are placed more like functions arguments
// and they are in fact acting quite similare to function
// arguments, except for typing

namespace DataStructures
{
    class LinkedListGenericNode<T>
    {
        public T Value;
        public LinkedListGenericNode<T>? Next;

        public LinkedListGenericNode(T value)
        {
            Value = value;
            Next = null;
        }
    }

    public class LinkedListGeneric<T>
    {
        private LinkedListGenericNode<T>? head;
        private LinkedListGenericNode<T>? current;

        public LinkedListGeneric()
        {
            head = null;
            current = null;
        }

        public void Add(T newValue)
        {
            LinkedListGenericNode<T> newNode = new LinkedListGenericNode<T>(newValue);

            if (head == null)
            {
                head = newNode;
                current = newNode;
            }
            else
            {
                LinkedListGenericNode<T> currentNode = head;

                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = newNode;
            }
        }

        public void Next()
        {
            if (current != null && current.Next != null)
            {
                current = current.Next;
            }
        }

        public void Start()
        {
            current = head;
        }

        public void PrintCurrent()
        {
            if (current != null)
            {
                System.Console.WriteLine($"Value: {current.Value}");
            }
            else
            {
                System.Console.WriteLine($"List is empty");
            }
        }

        public void PrintAll()
        {
            if (head != null)
            {
                System.Console.WriteLine("Printing all nodes");

                LinkedListGenericNode<T>? currentView = head;

                while (currentView != null)
                {
                    System.Console.WriteLine($"Value of Node: {currentView.Value}");
                    currentView = currentView.Next;
                }

                System.Console.WriteLine("All nodes visited");
            }
            else
            {
                System.Console.WriteLine("List was empty");
            }
        }
    }

    public class LinkedListGenericTest
    {
        static public void Run()
        {
            // Create a new instance of the linked list
            DataStructures.LinkedListGeneric<int> list = new DataStructures.LinkedListGeneric<int>();

            // Should be empty
            list.PrintCurrent();

            // Should be "10"
            list.Add(10);
            list.PrintCurrent();

            // Should still be "10"
            list.Add(20);
            list.PrintCurrent();

            list.Next();
            // Should now be "20"
            list.PrintCurrent();

            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.Add(60);

            // Should print all the nodes in ascending order
            list.PrintAll();
        }
    }
}