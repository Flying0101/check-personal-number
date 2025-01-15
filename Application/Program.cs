
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
                
                if (!LenghtChecker.NumberandLenghtChecker(personNumber) || !IsValid.IsValidPersonalNumber(personNumber))
                {
                    Console.WriteLine("Invalid Person number. Please try again!");
                }
                
            }

            while (!LenghtChecker.NumberandLenghtChecker(personNumber) || !IsValid.IsValidPersonalNumber(personNumber));

            Ending.TheEnd();
        }
    }
}
