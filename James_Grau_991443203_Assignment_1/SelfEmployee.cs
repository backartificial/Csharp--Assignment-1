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
     * This is class is used to hold a root SelfEmployee instance
     * 
     **/
    class SelfEmployee : Employee {
        // Initialize the needed class properties with the ability to return them when needed
        private double hourlyRate { get; }
        private int totalHours { get; }

        /**
         * 
         * This method is used to create a blank SelfEmployee constructor
         * 
         **/
        public SelfEmployee() : base() { }

        /**
         * 
         * This method is used to create a SelfEmployee instance with passed values
         * 
         * @param id: is the Employees id
         * @param name: is the Employees name
         * @param profession: is the Employees Profession
         * @param hourlyRate: is the Employees hourly rate
         * @param totalHour: is the Employees total hours
         * 
         **/
        public SelfEmployee(string id, string name, string profession, double hourlyRate, int totalHours) : base(id, name, profession) {
            // Assign this instances' variables based on the passed values
            this.id = id;
            this.name = name;
            this.profession = profession;
            this.hourlyRate = hourlyRate;
            this.totalHours = totalHours;
        }

        /**
         * 
         * This method is used to calculate and return an Employees wage
         * 
         * @return wage<double>: is an Employees calculated wage
         * 
         **/
        public double calculateWage() {
            // Return an Employees calculated wage based on their total hours and hourly rate
            return totalHours * hourlyRate;
        }

        /**
         * 
         * This method is used to return the employees information (from the base class) along with the hourly wage and total hours
         * 
         * @return information<string>: return the Employees overall information
         * 
         **/
        public override string employeeInformation() {
            // Return the base classes information along with the concatenated hourly wage and total hours worked
            return base.employeeInformation() + "\nHourly Rate: " + hourlyRate + "\nTotal Hours: " + totalHours;
        }
    }
}
