namespace check_personal_nr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string personNumber = " ";

            do
            {
                Console.WriteLine("Input your personal number below. (10 digits)");
                Console.WriteLine("YYMMDDXXXX");
                personNumber = Console.ReadLine();

                if (!IsValidPersonalNumber(personNumber))
                {
                    Console.WriteLine("Invalid Person number. Please try again!");
                }
            }
            while (!IsValidPersonalNumber(personNumber));
            Console.Clear();
            Console.WriteLine("Personal number accepted...");
            Console.WriteLine("Stealing your identity...");
            Thread.Sleep(1500);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"""
.-._                                                   _,-,
  `._`-._                                           _,-'_,'
     `._ `-._                                   _,-' _,'
        `._  `-._        __.-----.__        _,-'  _,'
           `._   `#===""""""           """"""===#'   _,'
              `._/)  ._               _.  (\_,'
               )*'     **.__     __.**     '*( 
               #  .==..__  """"   """"  __..==,  # 
               #   `""._(_).       .(_)_.""'   #
""");

            Thread.Sleep(2000);
            ExitMove();
        }

        public static bool IsValidPersonalNumber(string personNumber)
        {
            if (!personNumber.All(char.IsDigit) || personNumber.Length != 10)
            {
                return false;
            }

            int[] personNumberArray = new int[personNumber.Length];
            for (int i = 0; i < personNumber.Length; i++)
            {
                if (!int.TryParse(personNumber[i].ToString(), out personNumberArray[i]))
                    return false;
            }

            int month = personNumberArray[2] * 10 + personNumberArray[3];
            if (month < 0 || month > 12)
            {
                return false;
            }

            int day = personNumberArray[4] * 10 + personNumberArray[5];
            if (day < 0 || day > 31)
            {
                return false;
            }
            return true;
        }

        public static void ExitMove()
        {
            Console.Clear();

            string text = "HAHAHA";
            Console.ForegroundColor = ConsoleColor.Red;
           
            int centerY = Console.WindowHeight / 2;    // Center the HAHAHA text vertically
            for (int i = 0; i < text.Length; i++)
            {
                Console.Clear();
              
                string displayText = text.Substring(0, i + 1);     // Display the HAHAHA text one letter at a time
                int padding = (Console.WindowWidth - displayText.Length) / 2; // Center the text horizontally

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
