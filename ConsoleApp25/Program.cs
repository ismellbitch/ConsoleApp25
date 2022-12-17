using ConsoleApp25;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите сторону a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите сторону b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите сторону c: ");
        double c = double.Parse(Console.ReadLine());

        TriangleType type = new(a, b, c);

        string res = type.GetTriangleTyple();
        Console.WriteLine(res);
    }
}