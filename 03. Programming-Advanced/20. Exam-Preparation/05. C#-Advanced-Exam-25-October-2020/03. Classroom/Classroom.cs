using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public class Classroom
    {
        private List<Student> students;

        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
        }

        public int Capacity { get; }
        public int Count => students.Count;

        public string RegisterStudent(Student student)
        {
            if (Capacity <= Count)
            {
                return "No seats in the classroom";
            }

            students.Add(student);

            return $"Added student {student.FirstName} {student.LastName}"; 
        }

        public string DismissStudent(string firstName, string lastName)
        {
            bool isStudentExist = students.Exists(x => x.FirstName == firstName && x.LastName == lastName);

            if (isStudentExist)
            {
                students.Remove(students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName));

                return $"Dismissed student {firstName} {lastName}";
            }

            return "Student not found";
        }

        public string GetSubjectInfo(string subject)
        {
            var studentSubject = students.Where(x => x.Subject == subject).ToList();

            if (studentSubject.Count > 0)
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");

                foreach (var item in studentSubject)
                {
                    sb.AppendLine($"{item.FirstName} {item.LastName}");
                }

                return sb.ToString().TrimEnd();
            }

            return "No students enrolled for the subject";
        }

        public int GetStudentsCount() => Count;

        public Student GetStudent(string firstName, string lastName)
        {
            Student currentStudent = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

            return currentStudent;
        }
    }
}
