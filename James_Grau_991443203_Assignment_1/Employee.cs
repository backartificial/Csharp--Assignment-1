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

// Project Namespace
namespace James_Grau_991443203_Assignment_1 {
    /**
     * 
     * This is class is used to hold a root Employee instance
     * 
     **/
    abstract class Employee {
        // Initialize the needed class variables
        protected string id, name, profession;

        /**
         * 
         * This method is used to create a blank Employee constructor
         * 
         **/
        public Employee() { }

        /**
         * 
         * This method is used to create an Employee instance with passed values
         * 
         * @param id: is the Employees id
         * @param name: is the Employees name
         * @param profession: is the Employees Profession
         * 
         **/
        public Employee(string id, string name, string profession) {
            // Assign this instances' variables based on the passed values
            this.id = id;
            this.name = name;
            this.profession = profession;
        }

        /**
         * 
         * This method is used to return employee information for the Employee instnace
         * 
         * @return infroamtion<string>: return the Employee information in a string
         * 
         **/
        public virtual string employeeInformation() {
            // Return a string with the employees information
            return "Employee ID: " + id + "\nEmployee Name: " + name + "\nEmployee Profession: " + profession;
        }
    }
}
