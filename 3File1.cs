using System;
namespace Day_3
{
	    class Employee
	    {
	        private int employeeId;
	        private string employeename;
	        public Employee(int _employeeId,string emplpyeeName)
	        {
	            EmployeeId = _employeeId;
	            EmployeeName = _employeeName;
	        }
	        public ShowEmployeeDetails()
	        {
	            Console.WriteLine("EMployee ID :" + EmployeeId);
	            Console.WriteLine("EMployee name :" + EmployeeName);
	        }
	    }
	    class Program
	    {
	        static void Main ()
	        {
	            Employee emp = new Employee(101, "Mariah THomas");
	            emp.ShowEmployeeDetails();
	            Console.ReadLine();
		}
	}
}