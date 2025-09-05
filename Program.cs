namespace StackADT
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Come let us test stack!");
            Console.Write("Enter size of stack: ");
            int size = int.Parse(Console.ReadLine());
            IntegerStack s = new IntegerStack(size);

            while (true)
            {
                Console.WriteLine("\n--- Menu ---");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Print Stack");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());                
                int element;
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter value to push: ");
                        element = int.Parse(Console.ReadLine());
                        s.push(element);
                        break;

                    case 2:
                        element = s.pop();
                        if (element !=-1)
                            Console.WriteLine("Popped: " + element);                        
                        break;

                    case 3:
                        element = s.peek();
                        if (element!=-1)
                            Console.WriteLine("Top element: " + element);                        
                        break;

                    case 4:
                        s.print();
                        break;

                    case 5:
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}