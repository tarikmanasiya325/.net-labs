using System;
namespace EmployeePayrollSystem
{
    // Interface  
    interface IPayable
    {
        double CalculateSalary();
    }

    // Base Class 
    class Employee : IPayable
    {
        protected int empId;
        protected string empName;

        public virtual void GetDetails()
        {
            Console.Write("Enter Employee ID : ");
            empId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name : ");
            empName = Console.ReadLine();
        }

        public virtual double CalculateSalary()
        {
            return 0;
        }

        public virtual void DisplayDetails()
        {
        }
    }

    // Derived Class - Full Time Employee  
    class FullTimeEmployee : Employee
    {
        private double basicSalary;
        private double hra, da, pf, tax;
        private double grossSalary, netSalary;

        public override void GetDetails()
        {
            base.GetDetails();
            Console.Write("Enter Basic Salary : ");
            basicSalary = Convert.ToDouble(Console.ReadLine());

            // Earnings 
            hra = basicSalary * 0.20; // 20%  
            da = basicSalary * 0.10;  // 10% 

            // Deductions 
            pf = basicSalary * 0.12;  // 12%  
            tax = basicSalary * 0.05; // 5% 

            grossSalary = basicSalary + hra + da;
            netSalary = grossSalary - pf - tax;
        }

        public override double CalculateSalary()
        {
            return netSalary;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("\n======================================");
            Console.WriteLine(" FULL TIME EMPLOYEE PAYSLIP");
            Console.WriteLine("======================================");
            Console.WriteLine("Employee ID : " + empId);
            Console.WriteLine("Employee Name : " + empName);
            Console.WriteLine("\n---------- Earnings ----------");
            Console.WriteLine("Basic Salary : " + basicSalary);
            Console.WriteLine("HRA (20%) : " + hra);
            Console.WriteLine("DA (10%) : " + da);
            Console.WriteLine("Gross Salary : " + grossSalary);
            Console.WriteLine("\n---------- Deductions ----------");
            Console.WriteLine("PF (12%) : " + pf);
            Console.WriteLine("Tax (5%) : " + tax);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Net Salary : " + CalculateSalary());
            Console.WriteLine("======================================");
        }
    }

    // Derived Class - Part Time Employee  
    class PartTimeEmployee : Employee
    {
        private int hoursWorked;
        private double hourlyRate;
        private double basicSalary;
        private double pf, tax;
        private double netSalary;

        public override void GetDetails()
        {
            base.GetDetails();
            Console.Write("Enter Hours Worked : ");
            hoursWorked = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Hourly Rate : ");
            hourlyRate = Convert.ToDouble(Console.ReadLine());

            basicSalary = hoursWorked * hourlyRate;

            // Deductions 
            pf = basicSalary * 0.05;  // 5%  
            tax = basicSalary * 0.02; // 2% 

            netSalary = basicSalary - pf - tax;
        }

        public override double CalculateSalary()
        {
            return netSalary;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("\n======================================");
            Console.WriteLine(" PART TIME EMPLOYEE PAYSLIP");
            Console.WriteLine("======================================");
            Console.WriteLine("Employee ID : " + empId);
            Console.WriteLine("Employee Name : " + empName);
            Console.WriteLine("\n---------- Earnings ----------");
            Console.WriteLine("Hours Worked : " + hoursWorked);
            Console.WriteLine("Hourly Rate : " + hourlyRate);
            Console.WriteLine("Basic Salary : " + basicSalary);
            Console.WriteLine("\n---------- Deductions ----------");
            Console.WriteLine("PF (5%) : " + pf);
            Console.WriteLine("Tax (2%) : " + tax);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Net Salary : " + CalculateSalary());
            Console.WriteLine("======================================");
        }
    }

    // Main Class  
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = null;
            Console.WriteLine("======================================");
            Console.WriteLine(" EMPLOYEE PAYROLL SYSTEM");
            Console.WriteLine("======================================");
            Console.WriteLine("1. Full Time Employee");
            Console.WriteLine("2. Part Time Employee");
            Console.Write("Enter Your Choice : ");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    emp = new FullTimeEmployee();
                    break;
                case 2:
                    emp = new PartTimeEmployee();
                    break;
                default:
                    Console.WriteLine("Invalid Choice!");
                    return;
            }

            // Polymorphism  
            emp.GetDetails();
            emp.DisplayDetails();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

