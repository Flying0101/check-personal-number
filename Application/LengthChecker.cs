using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_personal_nr
{
    public class LenghtChecker : IsValid
    {
        public static bool NumberandLengthChecker(string personNumber)     // method checking that the personal number is within a given length
        {
            personNumber = personNumber.Replace("-", "").Replace(" ", "");     // removes spaces and "-"

            if (personNumber.Length == 12)
            {
                personNumber = personNumber.Substring(2);
            }

            if (personNumber.Length != 10 || !personNumber.All(char.IsDigit))
            {
                return false;
            }
            return true;                                                     // if the personal number is too long or short it will return false
        }
    }
}
