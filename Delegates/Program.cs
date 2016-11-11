namespace Delegates
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var grades = new Grade[5];
            grades[0] = new Grade { Name = "Joe", Score = 12.45f };
            grades[0].NameChanged += OnNameChanged;
            grades[1] = new Grade { Name = "John", Score = 14.45f };
            grades[1].NameChanged += OnNameChanged;
            grades[2] = new Grade { Name = "Lucy", Score = 15.45f };
            grades[2].NameChanged += OnNameChanged;
            grades[3] = new Grade { Name = "Mary", Score = 13.45f };
            grades[3].NameChanged += OnNameChanged;
            grades[4] = new Grade { Name = "Frank", Score = 16.45f };
            grades[4].NameChanged += OnNameChanged;

            var gradeBook = new GradeBook(grades);

            PrintGrades(gradeBook);
            ChangeGrades(gradeBook);
            PrintGrades(gradeBook);

            Console.Read();
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Name changed from: {args.ExistingName} To: {args.NewName}");
        }

        private static void ChangeGrades(GradeBook gradeBook)
        {
            gradeBook.Grades[0].Name = "Joe2";
            gradeBook.Grades[1].Name = "John22";
            gradeBook.Grades[2].Name = "Lucy2";
            gradeBook.Grades[3].Name = "Mary2";
            gradeBook.Grades[4].Name = "Frank2";
        }

        private static void PrintGrades(GradeBook gradeBook)
        {
            Console.WriteLine("--------------------------------------");

            foreach (var grade in gradeBook.Grades)
            {
                Console.WriteLine($"{grade.Name}'s grade is: {grade.Score}");
            }

            Console.WriteLine("--------------------------------------");
        }
    }
}