namespace STConsole
{
    internal static class Errors
    {
        public static void wrongNumber(string input)
        {
            System.Console.WriteLine("Please type in an integer that corresponds to an option presented. Then press enter.");
            System.Console.WriteLine($"Your incorrect input was {input}");
        }

        internal static void badInput(string input)
        {
            wrongNumber(input);
            System.Console.WriteLine("Your input must be a single number");
        }
    }
}