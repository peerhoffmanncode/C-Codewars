internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(true == Kata.Check(new object[] { 66, 101 }, 66));
        Console.WriteLine(true == Kata.Check(new object[] { 80, 117, 115, 104, 45, 85, 112, 115 }, 45));
        Console.WriteLine(true == Kata.Check(new object[] { 't', 'e', 's', 't' }, 'e'));
        Console.WriteLine(false == Kata.Check(new object[] { "what", "a", "great", "kata" }, "kat"));

        Console.ReadKey();
    }
}

public class Kata
{
    public static bool Check(object[] a, object x)
    {
        return Array.IndexOf(a, x) != -1;
    }
}