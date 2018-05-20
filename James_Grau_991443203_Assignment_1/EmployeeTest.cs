using System;

namespace James_Grau_991443203_Assignment_1 {
    class EmployeeTest {
        private static int selection = 1;
        private static SelfEmployee[] employees;


        static void Main(string[] args) {
            while (selection != 4) {
                switch(selection) {
                    case 1:
                        displayMenu();
                    break;

                    case 2:
                        addEmployee();
                    break;

                    case 3:
                        //viewEmployee();
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
            if(employees == null) {
                employees = new SelfEmployee[1];
            }

            Console.WriteLine("Please fill out the following prompts.");




        }
    }
}
