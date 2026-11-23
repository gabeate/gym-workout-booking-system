using System;
using System.Collections.Generic;
using System.Text;

namespace GymWorkoutFormProject
{
    public class Employee
    {
        private int employeeID;
        private string employeeName;
        private string password;
        private string role;

        public Employee()
        {
            employeeName = "";
            password = "";
            role = "";
        }

        public Employee(int employeeID, string employeeName, string password)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.password = password;
        }

        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Role
        {
            get { return role; }
            set {  role = value; }
        }
    }
}