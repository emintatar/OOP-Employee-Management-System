using System;
using System.IO;

namespace EmployeeManagementSystem
{
    class Program
    {
        static List<Employee> employees = new List<Employee>();

        static void Main(string[] args)
        {
            void printOptions()
            {
                Console.WriteLine();
                Console.WriteLine("###### Employee Management System ######");
                Console.WriteLine("1. View Employees");
                Console.WriteLine("2. Add Employee");
                Console.WriteLine("3. Update Employee");
                Console.WriteLine("4. Delete Employee");
                Console.WriteLine("5. Exit");
                Console.Write("Please make a selection ? > ");
            }

            void viewEmployees()
            {
                for (int i = 0; i < employees.Count(); i++)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine(employees[i].getEmployeeInfos());
                    Console.WriteLine("\n");
                }

                string option = "";
                while (option != "Q")
                {
                    Console.WriteLine();
                    Console.WriteLine("Press Q to return menu!");
                    Console.WriteLine();

                    option = Console.ReadLine().ToUpper();
                    if (option != "Q")
                    {
                        Console.WriteLine("Invalid option");
                    }

                    else
                    {
                        Console.WriteLine("Returning to menu...");
                        break;
                    }
                }
            }

            void addEmployee()
            {
                int employeeCount;

                Console.Write("How many employees do you want to add: ");
                employeeCount= int.Parse(Console.ReadLine());

                for (int i = 0; i < employeeCount; i++)
                {
                    Console.WriteLine();
                    Console.Write("Employee " + (i + 1));
                    Console.WriteLine();
                    employees.Add(new Employee());
                    Console.WriteLine();
                    Console.WriteLine("Employee " + (i + 1) + " has been added to the system successfully!");
                }
            }

            void updateEmployee()
            {
                string id;
                bool isEmployee = false;

                while (!isEmployee)
                {
                    Console.Write("Enter ID of the employee you want to update: ");
                    id = Console.ReadLine();

                    foreach (Employee employee in employees)
                    {
                        if (employee.getEmployeeId() == id)
                        {
                            employee.setSalary();
                            employee.setDepartment();
                            Console.WriteLine("Employee has been updated successfully!");
                            isEmployee = true;
                            break;
                        }
                    }

                    if (!isEmployee)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid ID!");
                    }
                }
            }

            void deleteEmployee()
            {
                string id;
                bool isEmployee = false;

                while(!isEmployee)
                {
                    Console.Write("Enter ID of the employee you want to delete: ");
                    id = Console.ReadLine();

                    foreach (Employee employee in employees)
                    {
                        if (employee.getEmployeeId() == id)
                        {
                            employees.Remove(employee);
                            isEmployee = true;
                            Console.WriteLine();
                            Console.WriteLine("Employee has been deleted successfully!");
                            break;
                        }
                    }

                    if (!isEmployee) 
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid ID!");
                    }
                }
            }

            Employee employee1 = new Employee("Bruce", "Wayne", "12345", 20000, "IT");
            Employee employee2 = new Employee("Clark", "Kent", "02468", 30000, "Marketing");
            Employee employee3 = new Employee("Tony", "Stark", "13579", 40000, "Human Resources");
            Employee employee4 = new Employee("Peter", "Parker", "86420", 50000, "Social Media");

            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);

            int option = 0;
            while (option != 5)
            {
                try
                {
                    printOptions();
                    option = int.Parse(Console.ReadLine());

                    if (option == 1)
                    {
                        viewEmployees();
                    }

                    else if (option == 2)
                    {
                        addEmployee();
                    }

                    else if (option == 3)
                    {
                        updateEmployee();
                    }

                    else if (option == 4)
                    {
                        deleteEmployee();
                    }

                    else if (option == 5)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Exiting the system...");
                    }

                    else
                    {
                        Console.WriteLine("Invalid Option");
                    }
                }

                catch (Exception ex) 
                { 
                    Console.WriteLine(ex.Message); 
                }
            }
        }
    }
}