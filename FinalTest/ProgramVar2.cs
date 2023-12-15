//using Utilities;
//using System.Globalization;
//using Utilities.DataModels.Var2;

namespace FinalTest
{
    class ProgramVar2
    {
        //static void Main()
        //{

        //    Assistance.Print("Нажмите Enter для продолжения или Escape для выхода...", ConsoleColor.Yellow);
        //    var key = Console.ReadKey(true).Key;

        //    if (key == ConsoleKey.Escape)
        //    {
        //        Thread.Sleep(400);
        //        Environment.Exit(0);
        //    }

        //    else if (key == ConsoleKey.Enter)
        //    {
        //        Console.Clear();
        //        Console.ForegroundColor = ConsoleColor.Green;

        //        do
        //        {
        //            PointSet pointSet = new();
        //            try
        //            {
        //                string[] lines = File.ReadAllLines("dots.txt");

        //                foreach (var line in lines)
        //                {
        //                    string[] points = line.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        //                    foreach (var point in points)
        //                    {
        //                        string[] coordinates = point.Split(';');
        //                        if (coordinates.Length == 2 &&
        //                            double.TryParse(coordinates[0], NumberStyles.Any, CultureInfo.InvariantCulture, out double x) &&
        //                            double.TryParse(coordinates[1], NumberStyles.Any, CultureInfo.InvariantCulture, out double y))
        //                        {
        //                            pointSet.AddPoint(new Point(x, y));
        //                        }
        //                    }
        //                }

        //                Console.WriteLine("[Данные успешно загружены]");
        //                Thread.Sleep(500);
        //                Console.Clear();

        //                Console.WriteLine($"[*]Исходный диаметр множества: {pointSet.Diameter}\n");

        //                string userInput = Checkers.StringIsNullOrEmptyCheck("Введите координаты новой точки (формат: X;Y): ", ConsoleColor.Green); ;
        //                string[] userCoordinates = userInput.Split(';');

        //                if (userCoordinates.Length == 2 &&
        //                    double.TryParse(userCoordinates[0], NumberStyles.Any, CultureInfo.InvariantCulture, out double newX) &&
        //                    double.TryParse(userCoordinates[1], NumberStyles.Any, CultureInfo.InvariantCulture, out double newY))
        //                {
        //                    Point newPoint = new Point(newX, newY);
        //                    pointSet.AddPoint(newPoint);

        //                    Console.WriteLine("\nНовый диаметр множества: " + pointSet.Diameter);
        //                }
        //                else
        //                {
        //                    Assistance.Print("\nНеверный формат ввода.", ConsoleColor.Red);
        //                    Thread.Sleep(1000);
        //                }
        //            }
        //            catch (ArgumentException ex)
        //            {
        //                Assistance.Print(ex.Message, ConsoleColor.DarkRed);
        //            }
        //            catch (NullReferenceException ex)
        //            {
        //                Assistance.Print(ex.Message, ConsoleColor.DarkRed);
        //            }
        //            catch (Exception ex)
        //            {
        //                Assistance.Print(ex.Message, ConsoleColor.DarkRed);
        //            }

        //            Assistance.Print("\nНажмите любую клавишу для продолжения или Escape для заврешения...", ConsoleColor.Yellow);

        //        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        //    }
        //}
    }
}
