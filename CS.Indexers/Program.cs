namespace CS.Indexers;

static class Program
{
    public static void Main(string[] args)
    {
        Student s1 = new Student(1, "Student 1", 100);

        s1[0] = "Math";
        s1[2] = "Physics";

        Console.WriteLine(s1[0]);
        Console.WriteLine(s1[111]);
    }
}