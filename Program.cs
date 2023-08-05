using System;
using com.hr;

namespace CSClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new("Fred", "Smith", 25000.00M);
            Console.WriteLine("Employee1 first name is " + employee1.Firstname);
            Console.WriteLine("Number of objects is " + Employee.count);

            Employee employee2 = new("Chevy", "Doe", 50000.00M);
            Console.WriteLine("Employee2 first name is " + employee2.Firstname);
            Console.WriteLine("Employee2 first name is " + employee2.Lastname);
            Console.WriteLine("Employee2 first name is " + employee2.Salary);

            Employee employee3 = new("Mic", "Mac", 50000.00M, 23);
            Console.WriteLine(employee3);
            Console.WriteLine("Number of objects is " + Employee.count);
        }
    }
}
