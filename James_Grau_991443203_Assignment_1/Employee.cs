using System;
using System.Collections.Generic;
using System.Text;

namespace James_Grau_991443203_Assignment_1 {
    class Employee {
        private int id;
        private string name, profession;

        public Employee(int id, string name, string profession) {
            this.id = id;
            this.name = name;
            this.profession = profession;
        }

        public string employeeInformation() {
            return "Employee ID: " + id + "\nEmployee Name: " + name + "\nEmployee Profession: " + profession;
        }
    }
}
