using System.Globalization;
using Utilities.DataModels.Var4;

namespace Utilities
{
    public class Assistance
    {
        public static void Print(string? inputText, ConsoleColor color)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(inputText);
            Console.ForegroundColor = defaultColor;
        }

        public static List<Point> ReadPointsFromFile(string filePath)
        {
            var points = new List<Point>();
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split(new[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var part in parts)
                {
                    var coordinates = part.Split(';');
                    if (coordinates.Length == 2 &&
                        double.TryParse(coordinates[0].Trim(new[] { '(', ')' }), NumberStyles.Any, CultureInfo.InvariantCulture, out double x) &&
                        double.TryParse(coordinates[1].Trim(new[] { '(', ')' }), NumberStyles.Any, CultureInfo.InvariantCulture, out double y))
                    {
                        points.Add(new Point(x, y));
                    }
                }
            }
            return points;
        }
    }
}
