using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

namespace Day_3
{
    abstract class Employee
    {
       public int EmployeeID { get; set; }
       public int EmployeeName { get; set; }
       public Employee (int _employeeID, int _employeeName)
       {
           EmployeeID = _employeeID;
           EmployeeName = _employeeName;
       }
    }
    class Class8:Employee
    {
        Class8(int _employeeID, string _employeeName) :base(_employeeID, _employeeName)
        {
            
        }
        public void PrintData()
        {
            Console.WriteLine("EmployeeID: "+ EmployeeID);
            Console.WriteLine("EmployeeName: "+ EmployeeName);
            
        }
        public static void Main()
        {
            Class8 e = new Class8(101, "Hari");
            e.PrntData();
            Console.ReadLine();
        }
    }
}