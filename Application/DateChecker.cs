namespace check_personal_nr
{
    public class DateChecker
    {
        // method checking the month and date that they fit within given parameters
        public static bool DateofBirth(int[] numberArray)
        {
            IsValid isValid = new IsValid(); //new instance of IsValid Created

            int month = numberArray[2] * 10 + numberArray[3];
            if (month < 0 || month > 12)
            {
                return false;
            }

            int day = numberArray[4] * 10 + numberArray[5];
            if (day < 0 || day > 31)
            {
                return false;
            }
            // if not within given parameters it returns false
            return true;
        }
    }
}
