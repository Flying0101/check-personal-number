using check_personal_nr.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace check_personal_nr
{
    public class IsValid
    {
        public static bool IsValidPersonalNumber(string personNumber)                              // centrsl method to check all the bool methods, if one is fale the check is false
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
        public static int[] PersonNumberArray(string personNumber)                 // method where we create the array of our personal number to later use in our checking bool methods 
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
