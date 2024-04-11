namespace _4.Student
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            List<string> input = Console.ReadLine().Split().ToList();

            while (input[0] != "end")
            {

                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                string city = input[3];

                Student student = new Student();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.HomeTown = city;

                students.Add(student);
                input = Console.ReadLine().Split().ToList();
            }
            string filterCity = Console.ReadLine();


            List<Student> typeStudent = students
                .Where(s => s.HomeTown == filterCity)
                .ToList();

            foreach (Student student in typeStudent)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old. ");
            }
        }
    }

}