namespace Week4IntroToLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 3, 4, 7, 6, 4, 7, 8, 2, 8, 7, 4, 3, 2 };

            // query syntax
            var greaterThan4 = from n in array
                               where n > 4
                               orderby n
                               select n;


            // method syntax
            var greaterThan5 = array.Where(n => n > 5).OrderByDescending(n => n);


            foreach (var i in greaterThan5)
                Console.Write(i + " ");
            Console.WriteLine("\n\n");



            List<string> colors = new List<string>();
            colors.Add("GreEN");
            colors.Add("rUsT");
            colors.Add("BluE");
            colors.Add("ReD");

            var startsWithR = from c in colors
                              let uppcaseColors = c.ToUpper()
                              where uppcaseColors.StartsWith("R")
                              orderby uppcaseColors
                              select uppcaseColors;

            foreach (var i in startsWithR)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");


            colors.Add("rUbY");
            colors.Add("PiNk");

            
            // deferred execution

            foreach (var i in startsWithR)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");



            // Employee example

            List<Employee> employees = new List<Employee>()
            {
                new Employee("John", "Green", 4000),
                new Employee("Anne", "Green", 6000),
                new Employee("Mat", "Blue", 7000),
                new Employee("James", "Indigo", 3000),
                new Employee("Kristie", "Indigo", 5000),
                new Employee("John", "Brown", 5500),
                new Employee("Maggie", "White", 2000)
            };

            foreach (var e in employees)
                Console.WriteLine(e);
            Console.WriteLine("\n\n");


            var between4k6k = from e in employees
                              where e.Salary >= 4000 && e.Salary <= 6000
                              select e;

            foreach (var e in between4k6k)
                Console.WriteLine(e);
            Console.WriteLine("\n\n");


            var sortedEmps = from e in employees
                             orderby e.LastName, e.FirstName
                             select e;

            foreach (var e in sortedEmps)
                Console.WriteLine(e);
            Console.WriteLine("\n\n");


            var lastnames = from e in employees
                            select e.LastName;

            foreach (var e in lastnames.Distinct())
                Console.WriteLine(e);
            Console.WriteLine("\n\n");


            var empNames = from e in employees
                           select new { e.FirstName, e.LastName };

            foreach (var e in empNames)
                Console.WriteLine(e);
            Console.WriteLine("\n\n");
        }
    }
}
