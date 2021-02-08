using System;

namespace LDMSTechnicalTest
{
    public class Employee
    {
        /// <summary>
        /// The unique identifier for the employee.
        /// </summary>
        public int EmployeeId { get; set; }
        /// <summary>
        /// The name of the employee.
        /// </summary>
        public string EmployeeName { get; set; }
        /// <summary>
        /// The job role undertaken by the employee. Some employees may undertaken the same job role
        /// </summary>
        public string JobTitle { get; set; }
        /// <summary>
        /// Line Manager of the employee
        /// </summary>
        public int? ManagerId { get; set; }
        /// <summary>
        /// The date the employee was hired
        /// </summary>
        public DateTime DateHired { get; set; }
        /// <summary>
        /// Current salary of the employee
        /// </summary>
        public decimal Salary { get; set; }
        /// <summary>
        /// Each employee must belong to a department.
        /// </summary>       
        public int DepartmentId = new Department().DepartmentId;
    }
}