using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_personal_nr
{
    public class DateChecker 
    {
        public static bool DateofBirth(int[] numberArray)                  // method checking the month and date that they fit within given parameters
        {
            IsValid isValid = new IsValid();                               //new instance of IsValid Created

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
            return true;                                      // if not within given parameters it returns false
        }
    }
}
