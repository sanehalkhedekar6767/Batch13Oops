using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class AccessModifiersDemoPublic
    {
        public class Employee
        {
            protected int employeeId;
            protected String employeeName;
            protected String address;
        }
        //public void SetField(int employeeId, String employeeName, String address)
        //{
        //    this.employeeId = employeeId;
        //    this.employeeName = employeeName;
        //    this.address = address;
        //}
        //public void Display()
        //{
        //    Console.WriteLine("Employee Id: "+id);
        //    Console.WriteLine("Employee Name: " + name);
        //    Console.WriteLine("Employee Address: " + address);

        //}
        static void Main()
        {
            Employee emp = new Employee(); 
            
        }
    }
}
