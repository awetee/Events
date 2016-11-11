namespace Delegates
{
    using System;

    public class GradeBook
    {
        public GradeBook(Grade[] grades)
        {
            this.Grades = grades;
        }

        public Grade[] Grades { get; set; }
    }

    public class Grade
    {
        private string _name;

        public string Name
        {
            get { return this._name; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if (this._name != value)
                    {
                        this.NameChanged?.Invoke(this, new NameChangedEventArgs { ExistingName = this._name, NewName = value });
                    }

                    this._name = value;
                }
            }
        }

        public event NameChangedDelegate NameChanged;

        public float Score { get; set; }
    }
}