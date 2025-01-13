using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_personal_nr
{
    public class IsValid
    {
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
    }
}
