using System;
using System.Collections.Generic;

namespace LinqLanguageIntegratedQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LINQ
            var stundents = new List<Student>
            {
                new Student(1, "Luis", "12345678910", 100),
                new Student(2, "Roberto", "98765432110", 35),
                new Student(3, "Bianca", "32165498701", 85),
                new Student(4, "Helena", "78945612301", 70),
                new Student(5, "Luis", "43265487699", 75)
            };
            #endregion LINQ

            Console.ReadKey();
        }
    }

    public class Student
    {
        public Student(int id, string fullName, string document, int grade)
        {
            Id = id;
            FullName = fullName;
            Document = document;
            Grade = grade;

            PhoneNumbers = new List<string> { "1233233232", "23412412312", "2809138231" };
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Document { get; set; }
        public int Grade { get; set; }
        public List<string> PhoneNumbers { get; set; }

    }
}
