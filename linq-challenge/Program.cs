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
                new Student("alice", 18, 80),
                new Student("ahmad", 17, 90),
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
            
            Console.ReadLine();
        }
    }
}
