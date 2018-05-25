/**
 * 
 * File: SelfEmployee.cs
 * Developer: James Grau
 * Date: May 20, 2018
 * 
 * Assignment: 1
 * Author: James Grau
 * Student Number: 991443203
 * Class: PROG 37721
 * 
 **/

// Include the needed packages
using System;
using System.Collections.Generic;

// Project Namespace
namespace James_Grau_991443203_Assignment_1 {
    /**
     * 
     * This is class is used to test out Employees/using the Employee Management System
     * 
     **/
    class EmployeeTest {
        // Initialize the needed class variables
        private static int option = 1;
        private static List<SelfEmployee> employees = new List<SelfEmployee>();
        private static String programTitle = "Employee Management System";
        
        /**
         * 
         * This method is used to run the Employee Management System Application
         * 
         * @param args: are command-line arguments
         * 
         **/
        static void Main(string[] args) {
            // Set the consoles title
            Console.Title = programTitle;

            // Loop thorugh the menu item while the option is not 4 (exit)
            while (option != 4) {
                // Perform switch on the entered menu option
                switch (option) {
                    // Perform action for menu option 1 (menu)
                    case 1:
                        // Clear console
                        Console.Clear();

                        // Set the Console title
                        Console.Title = programTitle;

                        // Call the displayMenu Method
                        displayMenu();
                    break;

                    // Perform action for menu option 2 (addEmployee)
                    case 2:
                        // Call the addEmployee Method
                        addEmployee();

                        // Set the menu option to 1 (menu) to stop from looping
                        option = 1;
                    break;

                    // Perform action for menu option 3 (viewEmployee)
                    case 3:
                        // Call the viewEmployee Method
                        viewEmployee();

                        // Set the menu option to 1 (menu) to stop from looping
                        option = 1;
                    break;

                    // Perform action for invalid menu option
                    default:
                        // Display a message stating that the entered menu option is not a valid option (1-3[4])
                        Console.WriteLine("\nOops... That is an invalid menu selection.  Please Try again.\n\n");

                        // Set the menu option to 1 (menu) to stop from looping
                        option = 1;
                    break;
                }

            }
        }

        /**
         * 
         * This method is used for display the application menu to the comsole.
         * 
         **/
        private static void displayMenu() {
            // Write the menu to the console
            Console.WriteLine("Welcome to the Employee Management System!");
            Console.WriteLine("");
            Console.WriteLine("Please select an option below.");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. Menu");
            Console.WriteLine("2. Add Employee");
            Console.WriteLine("3. View Employee(s)");
            Console.WriteLine("4. Exit");
            Console.WriteLine("------------------------------");
            
            // Propt the user to enter their menu option
            Console.Write("Option: ");
            option = int.Parse(Console.ReadLine()); // Store the option in to the options variable
        }

        /**
         * 
         * This method is used to handle asking the user to input information for adding an Employee and adding it into the Employees list
         * 
         **/
        private static void addEmployee() {
            // Initialize the needed method variables
            string id, name, profession, repeat;
            double hourlyRate;
            int totalHours;

            // Clear the console (for a fresh look) and change the title to reflect the current fucntion of the program
            Console.Clear();
            Console.Title = "Add Employee | " + programTitle;

            // Display the main message in the console
            Console.WriteLine("Please fill out the following prompts. Once competed successfully, you will be directed back to the main menu.");

            /**
             * 
             * Start prompting the user to enter Employee information by asking the needed fields followed by store the entered data into its respective variables
             * 
             **/
             // Ask user for Employee ID
            Console.Write("Please enter Employee ID: ");
            id = Console.ReadLine();

            // Ask user for Employee Name
            Console.Write("Please enter Employee Name: ");
            name = Console.ReadLine();

            // Ask the user for Employee Profession
            Console.Write("Please enter Employee Profession: ");
            profession = Console.ReadLine();

            // Ask the user for Employee Hourly Rate
            Console.Write("Please enter Hourly Rate: ");
            hourlyRate = double.Parse(Console.ReadLine());


            // ASk the user for Employee total hours
            Console.Write("Please enter Total Hours: ");
            totalHours = int.Parse(Console.ReadLine());

            // Take the added information (stored in the variables) and pass them along to create a new SelfEmployee instance and then sore it into the employees List
            employees.Add(new SelfEmployee(id, name, profession, hourlyRate, totalHours));

            // Ask the user if they want to enter another user
            Console.Write("Would you like to add another Employee? Yes (y/Y) or No (n/N): ");
            repeat = Console.ReadLine();

            // Loop if the input is not Y/N
            while ((repeat.ToUpper() != "Y") && (repeat.ToUpper() != "N")) {
                Console.WriteLine("Oops... That is an invalid option.  Please try again.");

                // Ask the user if they want to enter another user
                Console.Write("Would you like to add another Employee? Yes (y/Y) or No (n/N): ");
                repeat = Console.ReadLine();
            }

            // If the users wants to repeat adding another imployee then call this fucntion again
            if(repeat.ToUpper() == "Y") {
                // Call the add employee function again
                addEmployee();
            }

        }

        /**
         * 
         * This method is used for displaying the list of Employees
         * 
         **/
        private static void viewEmployee() {
            // Clear the console (for a fresh look) and change the title to reflect the current fucntion of the program
            Console.Clear();
            Console.Title = "View Employee(s) | " + programTitle;

            // Display the table header to the console
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(String.Format("|{0,13}|{1,20}|{2,20}|{3,12}|{4,24}|{5,16}|", "Employee Id", "Employee Name", "Profession", "Hourly Rate", "Total Hours (Bi Weekly)", "Calculated Wage"));
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

            // Check if there is no Employees in the Employees list
            if (employees.Count == 0) {
                // Display a message stating that the Employees list is empty
                Console.WriteLine(String.Format("|{0,110}|", "Oops... There are no Employees to display. Please add an Employee and chank back here!".PadRight(98)));
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            } else {
                // Loop through each employee in the Employees list and print their data
                foreach (SelfEmployee employee in employees) {
                    // Write the Employees information to the console
                    Console.WriteLine(employee.employeeInformation());
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
                }
            }

            // Display a message stating that the user needs to press the enter key to return back to the main menu
            Console.WriteLine("\n\nPress the 'Enter' key to return to the main level.");

            // Hold the console to display the Employees
            Console.ReadLine();
        }
    }
}
