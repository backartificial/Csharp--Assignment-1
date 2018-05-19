using System;

namespace James_Grau_991443203_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee e = new Employee(1, "James Grau", "Computer Programmer");
            Console.WriteLine("Hello World!");
            Console.WriteLine(e.employeeInformation());

            Console.Read();
        }
    }
}
