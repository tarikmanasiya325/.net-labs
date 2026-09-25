using System;

namespace ConsoleApp3
{
    class Expenses
    {
        public string Name;
        public string Category;
        public double Amount;

        // Constructor
        public Expenses(string name, string category, double amount)
        {
            Name = name;
            Category = category;
            Amount = amount;
        }

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Category: " + Category);
            Console.WriteLine("Amount: $" + Amount);
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Expenses[] expense = new Expenses[5];
            int count = 0;
            int choice;

            do
            {
                Console.WriteLine("\n===== Expense Tracker =====");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. View Expenses");
                Console.WriteLine("3. Total Expense");
                Console.WriteLine("4. Exit");
                Console.Write("Enter Choice: ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            if (count >= expense.Length)
                            {
                                Console.WriteLine("Expense list is full.");
                                break;
                            }

                            Console.Write("Enter Name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter Category: ");
                            string category = Console.ReadLine();

                            Console.Write("Enter Amount: ");
                            double amount = Convert.ToDouble(Console.ReadLine());

                            if (amount <= 0)
                                throw new Exception("Amount must be greater than 0.");

                            expense[count] = new Expenses(name, category, amount);
                            count++;
                            Console.WriteLine("Expense Added Successfully!");
                            break;

                        case 2:
                            if (count == 0)
                            {
                                Console.WriteLine("No expenses found.");
                            }
                            else
                            {
                                for (int i = 0; i < count; i++)
                                {
                                    expense[i].Display();
                                }
                            }
                            break;

                        case 3:
                            double total = 0;
                            for (int i = 0; i < count; i++)
                            {
                                total += expense[i].Amount;
                            }
                            Console.WriteLine("Total Expense = $" + total);
                            break;

                        case 4:
                            Console.WriteLine("Thank You!");
                            break;

                        default:
                            Console.WriteLine("Invalid Choice.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter valid input.");
                    choice = 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    choice = 0;
                }
            }
            while (choice != 4);
        }
    }
}
