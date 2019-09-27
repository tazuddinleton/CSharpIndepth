using System;

namespace CSharpIndepth.Indexers
{
    public class Student
    {
        private int _maxIndex = 4;
        private string[] _courses;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student()
        {
            _courses = new string[_maxIndex];
        }
        public Student(int g)
        {
            Grade = g;
            _courses = new string[_maxIndex];
        }

        public Student(int i, string n, int g)
        {
            Id = i;
            Name = n;
            Grade = g;
            _courses = new string[_maxIndex];
        }

        public string this[int index]
        {

            get
            {
                if (index > _maxIndex)
                {
                    throw new IndexOutOfRangeException();
                }
                return _courses[index];
            }
            set
            {
                if (index > _maxIndex)
                {
                    throw new IndexOutOfRangeException();
                }
                _courses[index] = value;
            }
        }


    }

}
