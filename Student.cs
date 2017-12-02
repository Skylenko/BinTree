using System;

namespace ConsoleApplication
{
    class Student : IComparable
    {
        private string DateOfExam { get; }
        private string Name { get; }
        private string Subject { get; }
        private int Mark { get; set; }

        public Student(string dateOfExam, string name, string subject, int mark)
        {
            DateOfExam = dateOfExam;
            Name = name;
            Subject = subject;
            Mark = mark;
        }

        public int CompareTo(object other)
        {
            return string.Compare(Name, ((Student)other).Name, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return Name + " " + DateOfExam + " " + Subject + " " + Mark;
        }
    }
}