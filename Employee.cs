using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM
{
    public class Employee
    {

        private string firstName;
        private string lastName;

        private int numberOfHoursWorked;
        private double wage;
        private double hourlyRate = 0;
        private double bonus = 0;

        

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }


        public int NumberOfHoursWorked
        {
            get
            {
                return numberOfHoursWorked;
            }
            set
            {
                numberOfHoursWorked = value;
            }
        }


        public double Wage
        {
            get
            {
                return wage;
            }
            set
            {
                if (value < 0)
                {
                    wage = 0;
                }
                else
                {
                    wage = value;
                }
            }
        }

        public double HourlyRate
        {
            get
            {
                return hourlyRate;
            }
            set
            {
                hourlyRate = value;
            }
        }

        public double Bonus
        {
            get
            {
                return bonus;
            }
            set
            {
                bonus = value;
            }
        }



        public Employee(string first, string last, double rate)
        {
            FirstName = first;
            LastName = last;
            HourlyRate = rate;

        }

        public int PerformWork(int hours)
        {
            NumberOfHoursWorked = +hours;
            return NumberOfHoursWorked;

        }

        public double ReceiveWage(out int hoursWorked)
        {
            Wage = NumberOfHoursWorked * HourlyRate + bonus;

            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}.");
            numberOfHoursWorked = 0;
            bonus = 0;
            hoursWorked = NumberOfHoursWorked;

            return Wage;
        }
        

        
    }
}
