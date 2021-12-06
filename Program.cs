using System;
using System.Collections.Generic;

namespace BethanyPieShopHRM
{
    class Program
    {
        private static List<Employee> employees = new List<Employee>();

        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***********************************");
            Console.WriteLine("* Bethany's Pie Shop Employee App *");
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;

            string userSelection;

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("*****************");
                Console.WriteLine("* Select action *");
                Console.WriteLine("*****************");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("1: Register employee");
                Console.WriteLine("2: Register work hours for employee");
                Console.WriteLine("3: Pay employee");
                Console.WriteLine("4: Change the rate");
                Console.WriteLine("5: Add bonus");
                Console.WriteLine("9: Quit application");

                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "1":
                        RegisterEmployee();
                        break;
                    case "2":
                        RegisterWork();
                        break;
                    case "3":
                        PayEmployee();
                        break;
                    case "4":
                        ChangeRate();
                        break;
                    case "5":
                        Bonus();
                        break;
                    case "9": break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }
            }
            while (userSelection != "9");

            Console.WriteLine("Thanks for using the application");
            Console.Read();

        }

        private static void RegisterEmployee()
        {
            Console.WriteLine("Creating an employee");
            Console.Write("Enter the first name: ");
            string firstname = Console.ReadLine();

            Console.Write("Enter the last name ");
            string lastname = Console.ReadLine();

            Console.Write("Enter the hourly rate: ");
            string hourlyRate = Console.ReadLine();
            double rate = double.Parse(hourlyRate);

            Employee employee = new Employee(firstname, lastname, rate);
            employees.Add(employee);

            Console.WriteLine("Employee created!\n\n");
        }

        private static void RegisterWork()
        {
            Console.WriteLine("Select an employee");

            for (int i = 1; i <= employees.Count; i++)
            {
                Console.WriteLine($"{i}. {employees[i - 1].FirstName} {employees[i - 1].LastName}");
            }

            int selection = int.Parse(Console.ReadLine());//we will assume here that a valid ID is selected

            Console.Write("Enter the number of hours worked: ");
            int hours = int.Parse(Console.ReadLine());//we will assume here that a valid amount was entered

            Employee selectedEmployee = employees[selection - 1];
            int numberOfHoursWorked = selectedEmployee.PerformWork(hours);
            Console.WriteLine($"{selectedEmployee.FirstName} {selectedEmployee.LastName} has now worked {numberOfHoursWorked} hours in total.\n\n");
        }
        private static void PayEmployee()
        {
            Console.WriteLine("Select an employee");

            for (int i = 1; i <= employees.Count; i++)
            {
                Console.WriteLine($"{i}. {employees[i - 1].FirstName} {employees[i - 1].LastName}");
            }


            int selection = int.Parse(Console.ReadLine());//we will assume here that a valid ID is selected

            Employee selectedEmployee = employees[selection - 1];
            int hoursWorked;
            double receivedWage = selectedEmployee.ReceiveWage(out hoursWorked);


            Console.WriteLine($"{selectedEmployee.FirstName} {selectedEmployee.LastName} has received a wage of {receivedWage}. The hours worked is reset to {hoursWorked}.\n\n");
        }


        private static void ChangeRate()
        {
            Console.WriteLine("Select an employee");

            for (int i = 1; i <= employees.Count; i++)
            {
                Console.WriteLine($"{i}. {employees[i - 1].FirstName} {employees[i - 1].LastName}");
            }
            int selection = int.Parse(Console.ReadLine());

            Console.Write("Enter the new hourly rate: ");
            string hourlyRate = Console.ReadLine();
            double newRate = double.Parse(hourlyRate);
            Employee selectedEmployee = employees[selection - 1];
            selectedEmployee.HourlyRate = newRate;
        }

        private static void Bonus()
        {
            Console.WriteLine("Select an employee");

            for (int i = 1; i <= employees.Count; i++)
            {
                Console.WriteLine($"{i}. {employees[i - 1].FirstName} {employees[i - 1].LastName}");
            }
            int selection = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the bonus: ");
            string bonus = Console.ReadLine();
            double addBonus = double.Parse(bonus);
            Employee selectedEmployee = employees[selection - 1];
            selectedEmployee.Bonus = addBonus;





        }





    }
}
