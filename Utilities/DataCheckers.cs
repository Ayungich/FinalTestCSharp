namespace Utilities
{
    public class Checkers
    {
        public static string StringIsNullOrEmptyCheck(string outputText, ConsoleColor color) // Проверка для строк
        {
            Assistance.Print(outputText, color);
            bool IsNullOrEmpty;
            string output;

            do
            {
                output = Console.ReadLine()!;
                IsNullOrEmpty = string.IsNullOrEmpty(output);

                if (IsNullOrEmpty)
                {
                    Assistance.Print("\nIncorrect data, please try again:\n-> ", ConsoleColor.DarkCyan);
                }
            } while (IsNullOrEmpty);

            return output;
        }
    }
}
