using System;
using System.Collections.Generic;
using System.Text;

namespace James_Grau_991443203_Assignment_1 {
    abstract class Employee {
        protected string id, name, profession;

        public Employee() {}

        public Employee(string id, string name, string profession) {
            this.id = id;
            this.name = name;
            this.profession = profession;
        }

        public virtual string employeeInformation() {
            return "Employee ID: " + id + "\nEmployee Name: " + name + "\nEmployee Profession: " + profession;
        }
    }
}
