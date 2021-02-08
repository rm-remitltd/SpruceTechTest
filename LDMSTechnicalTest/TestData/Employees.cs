using System;
using System.Collections.Generic;
using System.Linq;
using LDMSTechnicalTest.TestHelpers;

namespace LDMSTechnicalTest.TestData
{
    public static class Employees
    {
        public static Employee CEO => new Employee
        {
            EmployeeId = 1,
            EmployeeName = RandomStringBuilder.GenerateName(),
            JobTitle = JobTitles.CEO,
            ManagerId = null,
            DateHired = DateTime.Now.AddYears(-10),
            Salary = 1000000,
            DepartmentId = Departments.Management.DepartmentId
        };

        public static Employee EngineeringManager => new Employee
        {
            EmployeeId = 2,
            EmployeeName = RandomStringBuilder.GenerateName(),
            JobTitle = JobTitles.Manager,
            ManagerId = CEO.EmployeeId,
            DateHired = DateTime.Now.AddYears(-4),
            Salary = 25000,
            DepartmentId = Departments.Engineering.DepartmentId
        };

        public static Employee ResearchAndDevelopementManager => new Employee
        {
            EmployeeId = 3,
            EmployeeName = RandomStringBuilder.GenerateName(),
            JobTitle = JobTitles.Manager,
            ManagerId = CEO.EmployeeId,
            DateHired = DateTime.Now.AddYears(-4),
            Salary = 22000,
            DepartmentId = Departments.ReseachAndDevelopment.DepartmentId
        };

        public static Employee SalesManager => new Employee
        {
            EmployeeId = 4,
            EmployeeName = RandomStringBuilder.GenerateName(),
            JobTitle = JobTitles.Manager,
            ManagerId = CEO.EmployeeId,
            DateHired = DateTime.Now.AddYears(-4),
            Salary = 23000,
            DepartmentId = Departments.Sales.DepartmentId
        };

        public static Employee RandomEmployee()
        {
            var random = new Random();
            var jobTitles = JobTitles.All().Where(jt => jt != JobTitles.CEO).ToList();

            var employee = new Employee
            {
                EmployeeId = random.Next(5,1000),
                EmployeeName = RandomStringBuilder.GenerateName(),
                DateHired = DateTime.Now.AddYears(-random.Next(1, 11)),
                JobTitle = jobTitles[random.Next(jobTitles.Count)],
                ManagerId = random.Next(1, 4),
                Salary = random.Next(10000, 25001),
                DepartmentId = random.Next(1, 4)
            };
            
            return employee;
        }

        public static List<Employee> All()
        {
            var employees = new List<Employee>{CEO, EngineeringManager, ResearchAndDevelopementManager, SalesManager};

            for (var i = 5; i <= 10; i++)
            {
                employees.Add(RandomEmployee());
            }

            return employees;
        }
    }
}