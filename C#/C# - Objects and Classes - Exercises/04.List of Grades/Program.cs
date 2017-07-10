using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.List_of_Grades
{
    class ListOfGrades
    {
        public class Student
        {
            public string Name { get; set; }

            public double AverageGrades { get; set; }
            
        }

        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            var students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                students.Add(CreateStudent());
            }

             students = students.Where(n => n.AverageGrades >= 5.00).ToList();
            foreach (var student in students.OrderBy(n => n.Name).ThenByDescending(x => x.AverageGrades))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrades:F2}");
            }
        }

        private static Student CreateStudent()
        {
            var input = Console.ReadLine().Split().ToList();

            return new Student
            {
                 Name = input[0],
                 AverageGrades = input.Skip(1).Select(double.Parse).Average()
            };
        }
    }
}
