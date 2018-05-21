using System;
using System.Collections.Generic;

namespace James_Grau_991443203_Assignment_1 {
    class EmployeeTest {
        private static int selection = 1;
        private static List<SelfEmployee> employees;


        static void Main(string[] args) {
            Console.Title = "Employee Management System";

            while (selection != 4) {
                switch (selection) {
                    case 1:
                        Console.Clear();
                        displayMenu();
                        break;

                    case 2:
                        addEmployee();
                        selection = 1;
                        break;

                    case 3:
                        //viewEmployee();
                        selection = 1;
                        break;

                    default:
                        Console.WriteLine("\nOops... That is an invalid menu selection.  Please Try again.\n\n");
                        selection = 1;
                        break;
                }

            }

            /*SelfEmployee[] employees = new SelfEmployee[1];

            SelfEmployee se = new SelfEmployee("1", "James Grau", "Computer Programmer", 35.00, 50);
            Console.WriteLine(se.employeeInformation());*/
        }

        private static void displayMenu() {
            Console.WriteLine("Welcome to the Employee Management System!");
            Console.WriteLine("");
            Console.WriteLine("Please select an option below.");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. Menu");
            Console.WriteLine("2. Add Employee");
            Console.WriteLine("3. View Employee(s)");
            Console.WriteLine("4. Exit");
            Console.Write("Selection: ");
            selection = int.Parse(Console.ReadLine());
        }


        private static void addEmployee() {
            string id, name, profession;
            double hourlyRate;
            int totalHours;

            Console.Clear();

            Console.WriteLine("Please fill out the following prompts.");

            Console.Write("Please enter Employee ID: ");
            id = Console.ReadLine();

            Console.Write("Please enter Employee Name: ");
            name = Console.ReadLine();

            Console.Write("Please enter Employee Profession: ");
            profession = Console.ReadLine();

            Console.Write("Please enter Hourly Rate: ");
            hourlyRate = double.Parse(Console.ReadLine());

            Console.Write("Please enter Total Hours: ");
            totalHours = int.Parse(Console.ReadLine());

            employees.Add(new SelfEmployee(id, name, profession, hourlyRate, totalHours));

            Console.WriteLine("Employee has successfully been added!");
        }
    }
}
