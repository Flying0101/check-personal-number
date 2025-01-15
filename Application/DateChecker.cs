using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_personal_nr
{
    public class DateChecker 
    {
        

        public static bool DateofBirth(string personNumber, int[] numberArray)
        {
            IsValid isValid = new IsValid();

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
            return true;
        }
    }
}
