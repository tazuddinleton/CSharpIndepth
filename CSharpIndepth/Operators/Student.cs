namespace CSharpIndepth.Operators
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(int g)
        {
            Grade = g;
        }

        public Student(int i, string n, int g)
        {
            Id = i;
            Name = n;
            Grade = g;
        }

        public static Student operator +(Student s1, Student s2)
        {
            return new Student(s1.Grade + s2.Grade);
        }
    }
}
