namespace Delegates
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var grades = new Grade[5];
            var listener = new NameChangedDelegate(OnNameChanged);
            grades[0] = new Grade { NameChanged = listener, Name = "Joe", Score = 12.45f };
            grades[1] = new Grade { NameChanged = listener, Name = "John", Score = 14.45f };
            grades[2] = new Grade { NameChanged = listener, Name = "Lucy", Score = 15.45f };
            grades[3] = new Grade { NameChanged = listener, Name = "Mary", Score = 13.45f };
            grades[4] = new Grade { NameChanged = listener, Name = "Frank", Score = 16.45f };

            var gradeBook = new GradeBook(grades);

            PrintGrades(gradeBook);
            AddListener(gradeBook);
            ChangeGrades(gradeBook);

            Console.Read();
        }

        private static void AddListener(GradeBook gradeBook)
        {
            var listener = new NameChangedDelegate(OnNameChanged);
            foreach (var grade in gradeBook.Grades)
            {
                grade.NameChanged = listener;
            }
        }

        private static void OnNameChanged(string previousName, string newName)
        {
            Console.WriteLine($"Name changed from: {previousName} To: {newName}");
        }

        private static void ChangeGrades(GradeBook gradeBook)
        {
        }

        private static void PrintGrades(GradeBook gradeBook)
        {
            foreach (var grade in gradeBook.Grades)
            {
                Console.WriteLine($"{grade.Name}'s grade is: {grade.Score}");
            }
        }
    }
}