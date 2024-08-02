
namespace CS.Classes;

static class Program
{
    static void Main(string[] args)
    {
        var p = new Pen();
        var bp = new BlackPen();
        Console.WriteLine(p.GetItemCode());
        Console.WriteLine(bp.GetItemCode());

        Console.ReadLine();
    }
}