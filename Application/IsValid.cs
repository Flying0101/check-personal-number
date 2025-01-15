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
            
            LenghtChecker.NumberandLenghtChecker(personNumber);

            PersonNumberArray(personNumber);

            DateChecker.DateofBirth(personNumber, PersonNumberArray(personNumber));

            return true;
        }
        public static int[] PersonNumberArray(string personNumber)
        {

            int[] numberArray = new int[personNumber.Length];
            for (int i = 0; i < personNumber.Length; i++)
            {
                //if (!int.TryParse(personNumber[i].ToString(), out numberArray[i]))
                //{
                //    break;
                //}

                numberArray[i] = personNumber[i];


            }
            return numberArray;
        }



    }
}
