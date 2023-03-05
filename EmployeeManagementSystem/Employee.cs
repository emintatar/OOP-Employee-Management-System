using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private string employeeId;
        private int salary;
        private string department;

        public Employee()
        {
            try
            {
                Console.Write("First Name: ");
                this.firstName = Console.ReadLine();

                Console.Write("Last Name: ");
                this.lastName = Console.ReadLine();

                setEmployeeId();

                Console.Write("Salary: ");
                this.salary = int.Parse(Console.ReadLine());

                Console.Write("Department: ");
                this.department = Console.ReadLine();

                getEmployeeInfos();
            } 

            catch (Exception ex) 
            {
                Console.WriteLine("Error:" + ex);
            }
        }

        public Employee(string firstName, string lastName, string employeeId, int salary, string department)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.employeeId = employeeId;
            this.salary = salary;
            this.department = department;
        }

        public string getEmployeeInfos()
        {
            return "First Name: " + firstName + "\n" + "Last Name: " + lastName + "\n" + "Employee ID: " + employeeId + "\n" +  "Salary: " + salary + "\n" + "Department: " + department;
        }

        public string getEmployeeId()
        {
            return employeeId;
        }

        public void setEmployeeId()
        {
            for (int i = 0; i < 5; i++)
            {
                Random randomNumber = new Random();
                this.employeeId += randomNumber.Next(0, 10);
            }
        }

        public int getSalary()
        {
            return salary;
        }

        public void setSalary()
        {
            Console.Write("Current Salary: ");
            this.salary = int.Parse(Console.ReadLine());
        }

        public string getDepartment()
        {
            return department;
        }

        public void setDepartment()
        {
            Console.Write("Current Department: ");
            this.department = Console.ReadLine();
        }
    }
}
