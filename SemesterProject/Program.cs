namespace SemesterProject;

public static class Program
{
    public static void Main()
    {
        var svg = new SvgBuilder(500, 500)
            .AddRectangle(100, 50, 150, 200, "#FF000")
            .AddRectangle(100, 50, 150, 200, "#FF000")
            .Build();

        Console.Write("Absolute path to save SVG at: ");
        var path = Console.ReadLine() ?? "";
        using var streamWriter = new StreamWriter(path);

        streamWriter.WriteLine(svg);
    }
}
