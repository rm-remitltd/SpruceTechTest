using System.Collections.Generic;

namespace LDMSTechnicalTest.TestData
{
    public static class Departments
    {
        public static List<Department> All() => new List<Department>
        {
            Management,
            Engineering,
            ReseachAndDevelopment,
            Sales
        };
        
        public static Department Management => new Department
        {
            DepartmentId = 1,
            DepartmentName = "Management",
            Location = "London"
        };

        public static Department Engineering => new Department
        {
            DepartmentId = 2,
            DepartmentName = "Engineering",
            Location = "Cardiff"
        };

        public static Department ReseachAndDevelopment => new Department
        {
            DepartmentId = 3,
            DepartmentName = "Research & Development",
            Location = "Belfast"
        };

        public static Department Sales => new Department
        {
            DepartmentId = 4,
            DepartmentName = "Sales",
            Location = "Belfast"
        };
    }
}