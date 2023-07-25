internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Cockroach.CockroachSpeed(1.08) == 30);
        Console.WriteLine(Cockroach.CockroachSpeed(1.09) == 30);
        Console.WriteLine(Cockroach.CockroachSpeed(0) == 0);

        Console.ReadKey();
    }
}

public class Cockroach
{
    public static int CockroachSpeed(double x) => (int)(x * 100000) / (60 * 60);
}
