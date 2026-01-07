using System;
using System.Collections;

namespace Task10
{
    class Program
    {
        public int EmployeeID { get; set; }
        public int EmployeeName { get; set; }
        public double Salary { get; set; }

        private static ArrayList employee = new ArrayList();

        public Program(int EmployeeID,string name,double salary)
        {
            EmployeeID = employeeid;
            EmployeeName = employeename;

            Salary = salary;

        }
        public static bool AddEmployee(Program e)
        {
            if (e == null)
                return false;

            employee.Add(e);
            return true;
        }
        public static bool DeleteEmployee(int id)
        {
            foreach (Program emp in employee)
            {
                if(emp.EmployeeID==id)
                {
                    employee.Remove(emp);
                    return true;
                }
            }
            return false;
        }
        public static string?SearchEmployee(int id)
        {
            foreach(Program emp in employees)
            {
                if (emp.EmployeeID==id)
                {
                    return emp.EmployeeName;

                }
            }
            return null;
        }
        public static Program[]GetAllEmployeeListAll()
        {
            Program[] empArray = new Program[employee.Count];
            employees.CopyTO(empArray);
            return empArray;
        }
        static void main(string[] args)
        {
            AddEmployee(new Program(101, "Sathish", 50000));

            AddEmployee(new Program(102, "Arun", 60000));
            AddEmployee(new Program(103, "Akila", 65000));

            AddEmployee(new Program(104, "Mathi" , 600000));

            Console.WriteLine("Search Result:" + SearchEmployee(103));
            DeleteEmployee(102);

            Console.WriteLine("\nEmployee List:");
            foreach(Program emp in GetAllEmployeeListAll())
            {
                Console.WriteLine($"{emp.EmployeeID}{emp.EmployeeName}{emp.Salary}");
            }
            Console.WriteLine();
        }
    }
}
