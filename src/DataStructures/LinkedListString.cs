namespace DataStructures
{
    internal class LinkedListStringNode
    {
        public string Value;
        public LinkedListStringNode? Next;

        public LinkedListStringNode(string value)
        {
            Value = value;
            Next = null;
        }
    }

    public class LinkedListString
    {
        private LinkedListStringNode? head;
        private LinkedListStringNode? current;

        public LinkedListString()
        {
            head = null;
            current = null;
        }

        public void Add(string newValue)
        {
            LinkedListStringNode newNode = new LinkedListStringNode(newValue);

            if (head == null)
            {
                head = newNode;
                current = newNode;
            }
            else
            {
                LinkedListStringNode currentNode = head;

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

                LinkedListStringNode? currentView = head;

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

    public class LinkedListStringTest
    {
        static public void Run()
        {
            // Create a new instance of the linked list
            DataStructures.LinkedListString list = new DataStructures.LinkedListString();

            // Should be empty
            list.PrintCurrent();

            // Should be Foo
            list.Add("Foo");
            list.PrintCurrent();

            // Should still be "Foo"
            list.Add("Bar");
            list.PrintCurrent();

            list.Next();
            // Should now be "Bar"
            list.PrintCurrent();

            list.Add("Fizz");
            list.Add("Buzz");
            list.Add("Hello");
            list.Add("World");

            // Should print all the nodes in ascending order
            list.PrintAll();
        }
    }
}