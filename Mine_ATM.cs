using System;
namespace MineBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money=0;
            bool exit = true;
            Console.WriteLine("Welcom to mine bank\n");
            do
            {
                Console.WriteLine("Enter:\n1.Deposit\n2.Withdraw\n3.Exit");
                string op = Console.ReadLine();
                switch (op)
                {
                    case "1":
                        Console.WriteLine("How Many Deposit :");
                        money += int.Parse(Console.ReadLine());
                        break;
                    case "2":
                        Console.WriteLine("How Many Withdraw : ");
                        money -= int.Parse(Console.ReadLine());
                        break;
                    case "3":
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Enter only 1 to 3");
                        break;

                }
                Console.WriteLine($"Your Money is {money}");
            } while (exit);
        }
    }
}
