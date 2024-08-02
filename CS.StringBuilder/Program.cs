namespace CS.StringBuilder;

public class Program
{
    static void Main(string[] args)
    {
        // 2000 words
        var watch = System.Diagnostics.Stopwatch.StartNew();
        MakeSentenceString(MakeArray(10000));
        watch.Stop();
        Console.WriteLine(watch.ElapsedMilliseconds);
        // 20000 words
        watch = System.Diagnostics.Stopwatch.StartNew();
        MakeSentence(MakeArray(10000));
        watch.Stop();
        Console.WriteLine(watch.ElapsedMilliseconds);
        Console.ReadLine();
    }
    static string[] MakeArray(int num)
    {
        string[] arr = new string[num];
        for (int i = 0; i < num; i++)
        {
            arr[i] = "Word" + i.ToString();
        }
        return arr;
    }
    // string builder is lot efficient
    static string MakeSentence(string[] words)
    {
        System.Text.StringBuilder sentence = new System.Text.StringBuilder();
        foreach(var word in words)
        {
            sentence.Append(word).Append(" ");                
        }
        return sentence.ToString();
    }
    // a lot slower than StringBuilder
    static string MakeSentenceString(string[] words)
    {
        string sentence = "";
        foreach (var word in words)
        {
            sentence += word;
        }
        return sentence;
    }
}