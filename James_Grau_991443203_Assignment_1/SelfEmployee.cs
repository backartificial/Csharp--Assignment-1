using System;
using System.Collections.Generic;
using System.Text;

namespace James_Grau_991443203_Assignment_1 {
    class SelfEmployee : Employee {
        private double hourlyRate { get; }
        private int totalHours { get; }

        public SelfEmployee() : base() {}

        public SelfEmployee(string id, string name, string profession, double hourlyRate, int totalHours) : base(id, name, profession) {
            this.id = id;
            this.name = name;
            this.profession = profession;
            this.hourlyRate = hourlyRate;
            this.totalHours = totalHours;
        }

        public double calculateWage() {
            return totalHours * hourlyRate;
        }

        public override string employeeInformation() {
            return base.employeeInformation() + "\nHourly Rate: " + hourlyRate + "\nTotal Hours: " + totalHours;
        }
    }
}
