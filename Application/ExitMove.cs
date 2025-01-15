namespace check_personal_nr
{
    public static class ExitMove
    {
        public static void Exit()
        {
            Console.Clear();

            string text = "HAHAHA";
            Console.ForegroundColor = ConsoleColor.Red;

            // Center the HAHAHA text vertically
            int centerY = Console.WindowHeight / 2;
            for (int i = 0; i < text.Length; i++)
            {
                Console.Clear();

                // Display the HAHAHA text one letter at a time
                string displayText = text.Substring(0, i + 1);

                // Center the text horizontally
                int padding = (Console.WindowWidth - displayText.Length) / 2;

                Console.SetCursorPosition(padding, centerY);
                Console.Write(displayText);

                Thread.Sleep(500);
            }

            Thread.Sleep(2000);
            Console.Clear();

            string goodbyeMessage = "Goodbye!";
            int goodbyeX = (Console.WindowWidth - goodbyeMessage.Length) / 2;
            int goodbyeY = Console.WindowHeight / 2;
            Console.SetCursorPosition(goodbyeX, goodbyeY);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(goodbyeMessage);

            Thread.Sleep(2000);
            Console.ResetColor();

            Environment.Exit(0); // Exit the program
        }
    }
}
