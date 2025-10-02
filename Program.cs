using System;

namespace StackADT
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Clear console and set up colourful UI
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔════════════════════════════════════════════════════╗");
            Console.WriteLine("║        🚀 WELCOME TO THE ULTIMATE STACK TESTER     ║");
            Console.WriteLine("╠════════════════════════════════════════════════════╣");
            Console.WriteLine("║    Push | Pop | Peek | Print | Exit with STYLE     ║");
            Console.WriteLine("╚════════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.Write("\nEnter size of stack ➤ ");
            int size = int.Parse(Console.ReadLine());
            IntegerStack s = new IntegerStack(size);

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n╔═════════════════════════════════╗");
                Console.WriteLine("║           MAIN  MENU            ║");
                Console.WriteLine("╠═════════════════════════════════╣");
                Console.WriteLine("║ 1. ⬆ Push an element            ║");
                Console.WriteLine("║ 2. ⬇ Pop the top element        ║");
                Console.WriteLine("║ 3. 👀 Peek at the top           ║");
                Console.WriteLine("║ 4. 📜 Print stack               ║");
                Console.WriteLine("║ 5. 🔄 Reverse stack             ║");
                Console.WriteLine("║ 6. ❌ Exit                      ║");
                Console.WriteLine("╚═════════════════════════════════╝");
                Console.ResetColor();

                Console.Write("Enter your choice ➤ ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("⚠ Invalid input! Please enter a number 1–6.");
                    Console.ResetColor();
                    continue;
                }

                int element;
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter value to push ➤ ");
                        element = int.Parse(Console.ReadLine());
                        s.push(element);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"✅ Pushed {element} onto the stack!");
                        Console.ResetColor();
                        break;

                    case 2:
                        element = s.pop();
                        if (element != -1)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"⬇ Popped: {element}");
                            Console.ResetColor();
                        }
                        break;

                    case 3:
                        element = s.peek();
                        if (element != -1)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"👀 Top element: {element}");
                            Console.ResetColor();
                        }
                        break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("📜 Current Stack:");
                        s.print();
                        Console.ResetColor();
                        break;

                    case 5:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("🔄 Stack has been reversed!");
                        s.reverse();
                        s.print();
                        Console.ResetColor();
                        break;

                    case 6:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("❌ Exiting program... Goodbye, Stack Master!");
                        Console.ResetColor();
                        return;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("⚠ Invalid choice! Please try again.");
                        Console.ResetColor();
                        break;
                }
            }
        }
    }
}