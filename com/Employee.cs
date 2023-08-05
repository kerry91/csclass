namespace com.hr

/**
* - String firstname
* - String lastname
* - decimal salary
*/

{
    class Employee
    {
        private string firstname;

        private string lastname;

        private decimal salary;

        public static int count;

        public string Firstname
        {get; set;}

        public string Lastname
        {get; set;}

        public decimal Salary
        {get; set;}

        public int Years
        {get; set;}

        public Employee()
        {
            count++;
        }

        public override string ToString()
        {
            return "Employee [Firstname = " + Firstname + ", Lastname = "  + Lastname + ", Salary = " + Salary +
            ", Years = " + Years + "]";
        }

        public Employee(string firstname, string lastname, decimal salary)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Salary = salary;
            count++;
        }

        public Employee(string firstname, string lastname, decimal salary, int years)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Salary = salary;
            this.Years = years;
            count++;
        }
    }
}