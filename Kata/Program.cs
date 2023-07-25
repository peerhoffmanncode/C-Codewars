internal class Program
{
    private static void Main(string[] args)
    {
        List<int[]> peopleList = new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } };
        Console.WriteLine(Kata.Number(peopleList) == 5);
        peopleList = new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 10 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 10 } };
        Console.WriteLine(Kata.Number(peopleList) == 17);
        peopleList = new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 8 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 8 } };
        Console.WriteLine(Kata.Number(peopleList) == 21);

        Console.ReadKey();
    }
}

public class Kata
{
    public static int Number(List<int[]> peopleListInOut)
    {
        // LINQ alternatitve
        // return peopleListInOut.Sum(Item => Item[0] - Item[1]);

        int finalPeopleOnTheBus = 0;
        foreach (int[] item in peopleListInOut)
        {
            finalPeopleOnTheBus += item[0] - item[1];
        }
        return finalPeopleOnTheBus;
    }
}