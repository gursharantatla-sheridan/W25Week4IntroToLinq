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
        }
    }
}
