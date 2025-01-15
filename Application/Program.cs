
namespace check_personal_nr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string personNumber = " ";

            do                                                         // initial do while loop, if all the check bools are not correct the do while loop replays until a correct answe  is given
            {
                Console.WriteLine("Input your personal number below. (10 or 12 digits)");
                Console.WriteLine("YYMMDDXXXX");
                personNumber = Console.ReadLine();
                
                if (!LenghtChecker.NumberandLengthChecker(personNumber) || !IsValid.IsValidPersonalNumber(personNumber))
                {
                    Console.WriteLine("Invalid Person number. Please try again!");
                }
                
            }

            while (!LenghtChecker.NumberandLengthChecker(personNumber) || !IsValid.IsValidPersonalNumber(personNumber));

            Ending.TheEnd();
        }
    }
}
