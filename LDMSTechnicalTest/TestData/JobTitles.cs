using System.Collections.Generic;

namespace LDMSTechnicalTest.TestData
{
    public static class JobTitles
    {
        public static string SalesPerson => "SalesPerson";
        public static string Engineer => "Engineer";
        public static string Secretary => "Secretary";
        public static string ResearchAndDevelopment => "Research & Development";
        public static string Manager => "Manager";
        public static string CEO => "CEO";

        public static List<string> All() => new List<string> { SalesPerson, Engineer, Secretary, ResearchAndDevelopment, Manager, CEO };
    }
}
