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
                        this.NameChanged(this._name, value);
                    }

                    this._name = value;
                }
            }
        }

        public NameChangedDelegate NameChanged;

        public float Score { get; set; }
    }
}