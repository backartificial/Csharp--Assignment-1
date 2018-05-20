using System;

namespace James_Grau_991443203_Assignment_1
{
    class EmployeeTest
    {
        static void Main(string[] args)
        {

            SelfEmployee se = new SelfEmployee("1", "James Grau", "Computer Programmer", 35.00, 50);
            Console.WriteLine(se.employeeInformation());

            Console.Read();
        }
    }
}
