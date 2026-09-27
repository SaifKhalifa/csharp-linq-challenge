namespace linq_challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student("saif", 24, 50),
                new Student("john", 20, 60),
                new Student("bob", 19, 70),
                new Student("alice", 22, 80),
                new Student("ahmad", 22, 90),
                new Student("izz", 22, 100), //GOAT
                new Student("mo", 15, 0)

            };

            // Q3: Return the names of all students who are older than "20" and have a grade greater than or equal to "80".
            // The result should contain only the student names.
            var studetnsName =
                students
                .Where(n => n.Age > 20 && n.Grade >= 80)
                .Select(n => n.Name)
                .ToList();

            Console.WriteLine("Q3: Students who are older than 20 and have a grade greater than or equal to 80");
            Console.WriteLine(String.Join(", ", studetnsName));


            /* 
             * Q4: Group the students by age and return the following information for each age:
                1. Age
                2. Number of students
                3. Average grade
            */

            var studentsByAge = 
                students
                .GroupBy(s => s.Age)
                .Select(g => new
                {
                    Age = g.Key,
                    Count = g.Count(),
                    AverageGrade = g.Average(s => s.Grade)
                });

            Console.WriteLine("Q4: Students grouped by age:");

            foreach (var ageGroup in studentsByAge)
            {
                Console.WriteLine($"Age: {ageGroup.Age}");
                Console.WriteLine($" - NO of students: {ageGroup.Count}");
                Console.WriteLine($" - AVG Grade: {ageGroup.AverageGrade}");
            }


            Console.ReadLine();
        }
    }
}
