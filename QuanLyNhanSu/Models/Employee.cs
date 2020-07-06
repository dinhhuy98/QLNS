using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Models
{
    public class Employee
    {
        public String employeeId { get; set; }
        public String employeeName { get; set; }
        public String employeeEmail { get; set; }
        public String employeePhone { get; set; }
        public String employeeAddress { get; set; }
        public Employee()
        {

        }
        public Employee(String employeeId, String employeeName,String employeeEmail,String employeePhone,String employeeAddress)
        {
            this.employeeId = employeeId;
            this.employeeEmail = employeeEmail;
            this.employeeName = employeeName;
            this.employeePhone = employeePhone;
            this.employeeAddress = employeeAddress;
        }

        public static void deleteEmployeeById(String id)
        {
            //Entity.ListEmployee = Entity.ListEmployee.Where(emp => emp.employeeId != id);
            var item = Entity.ListEmployee.Single(emp => emp.employeeId == id);
            Entity.ListEmployee.Remove(item);
        }
        

    }
}
