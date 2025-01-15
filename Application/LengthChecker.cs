using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_personal_nr
{
    public class LenghtChecker : IsValid
    {
        public static bool NumberandLenghtChecker(string personNumber)
        {
            if (!personNumber.All(char.IsDigit) || personNumber.Length != 10)
            {
                return false;
            }
            return true;
        }
    }
}
