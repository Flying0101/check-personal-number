using check_personal_nr.Application;

namespace check_personal_nr
{
    public class IsValid
    {
        // method to check all the bool methods, if one is false the check is false
        public static bool IsValidPersonalNumber(string personNumber)
        {
            if (LenghtChecker.NumberandLengthChecker(personNumber) && !ControlNumber.ConrtolCheckNumber(personNumber))
            {
                return false;
            }
            if (DateChecker.DateofBirth(PersonNumberArray(personNumber)))
            {
                return false;
            }
            return true;
        }

        // method where we create the array of our personal number to later use in our checking bool methods 
        public static int[] PersonNumberArray(string personNumber)
        {
            int[] numberArray = new int[personNumber.Length];
            for (int i = 0; i < personNumber.Length; i++)
            {
                numberArray[i] = personNumber[i];
            }
            return numberArray;
        }
    }
}
