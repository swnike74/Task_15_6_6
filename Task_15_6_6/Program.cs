using System.Linq;

namespace Task_15_6_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
           {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            List<string> stud = new List<string>();
            
            stud = classes[0].Students.Concat(classes[1].Students).ToList();
            stud = stud.Concat(classes[2].Students).ToList();

            int j = 0;
            string[] s = new string[stud.Count];
            foreach (var student in stud)
                s[j++] = student;

            return s;
        }
    
    }
}
