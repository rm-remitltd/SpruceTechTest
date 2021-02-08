using System.Collections.Generic;
using System.Linq;

namespace LDMSTechnicalTest.Reports
{
    public class EmployeeReport
    {
        private readonly List<Employee> _employees;
        private readonly List<Department> _departments;
        public EmployeeReport(List<Employee> employees, List<Department> departments)
        {
            _employees = employees;
            _departments = departments;
        }

        public List<Dictionary<string,string>> EmployeesInDepartment(string departmentName)
        {
            var department = _departments.Single(d => d.DepartmentName == departmentName);

            return _employees.Where(e => e.DepartmentId == department.DepartmentId)
                    .Select(e => new Dictionary<string, string>
                        {
                            { "Employee Id", e.EmployeeId.ToString() },
                            { "Employee Name", e.EmployeeName },
                            { "Job Title", e.JobTitle },
                            { "Salary", e.Salary.ToString() }
                        }
                    ).ToList();
        }

        public List<Dictionary<string,string>> EmployeesInLocation(string location)
        {
            var department = _departments.Single(d => d.Location == location);

            return _employees.Where(e => e.DepartmentId == department.DepartmentId)
                    .Select(e => new Dictionary<string, string>
                        {
                            { "Employee Id", e.EmployeeId.ToString() },
                            { "Employee Name", e.EmployeeName },
                            { "Job Title", e.JobTitle },
                            { "Salary", e.Salary.ToString() },
                            { "Department Name", department.DepartmentName}
                        }
                    ).ToList();
        }
    }
}
