namespace AMBEmpleados.Models
{
    using System;

    public class Employee
    {
        public int Code { get; private set; }

        public string CompleteName { get; set; }

        public DateTime Born { get; set; }

        public DateTime Hiring { get; set; }

        public Decimal SalaryPerHour { get; set; }

        public bool Unsubscribe { get; set; }

        public Employee(int _code)
        {
            Code = Code;
        }
    }
}
