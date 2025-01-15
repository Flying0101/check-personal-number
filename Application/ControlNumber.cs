namespace check_personal_nr.Application
{
    public class ControlNumber
    {
        //method checking the last number of the personal number 
        public static bool ConrtolCheckNumber(string personNumber)
        {
            var digits = personNumber.Substring(0, 9)
                                     .Select(c => int.Parse(c.ToString()))
                                     .ToArray();

            var checkDigit = int.Parse(personNumber[9].ToString());

            var sum = 0;
            for (var i = 0; i < digits.Length; i++) //Luhn Algorithm Calculation
            {
                var digit = digits[i];

                if (i % 2 == 0)
                {
                    digit *= 2;

                    if (digit > 9)
                    {
                        digit = (digit % 10) + 1;
                    }
                }
                sum += digit;
            }

            var calculatedCheckDigit = (10 - (sum % 10)) % 10;

            // if correct the bool method returns true if not false
            return calculatedCheckDigit == checkDigit;
        }
    }
}
