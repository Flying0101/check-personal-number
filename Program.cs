namespace check_personal_nr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pnr = " ";
            bool nrCheck;
            bool lenghtCheck;
            bool monthCheck;
            bool dayCheck;

            do
            {
                nrCheck = true;
                lenghtCheck = true;
                monthCheck = true;
                dayCheck = true;
                Console.WriteLine("Input your personal number below. (10 digits)");
                Console.WriteLine("YYMMDDXXXX");
                pnr = Console.ReadLine();

                int[] pnrArray = new int[pnr.Length];
                for (int i = 0; i < pnr.Length; i++)
                {
                    pnrArray[i] = 0;
                }
                for (int i = 0; i < pnr.Length; i++)
                {
                    pnrArray[i] = int.Parse(pnr[i].ToString());
                }

                if (pnr.All(char.IsDigit))
                {
                    nrCheck = false;
                }

                if (pnrArray.Length == 10)
                {
                    lenghtCheck = false;
                }
                else
                {
                    continue;
                }

                if (0 <= (pnrArray[2] * 10 + pnrArray[3]) && ((pnrArray[2] * 10 + pnrArray[3]) <= 12))
                {
                    monthCheck = false;
                }

                if (0 <= (pnrArray[4] * 10 + pnrArray[5]) && ((pnrArray[4] * 10 + pnrArray[5]) <= 31))
                {
                    dayCheck = false;
                }

                
            }
            while (nrCheck || lenghtCheck || monthCheck || dayCheck);

            Console.WriteLine("Personal number accepted...");
            Console.WriteLine("Stealing your identity...");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"""
.-._                                                   _,-,
  `._`-._                                           _,-'_,'
     `._ `-._                                   _,-' _,'
        `._  `-._        __.-----.__        _,-'  _,'
           `._   `#===""""""           """"""===#'   _,'
              `._/)  ._               _.  (\_,'
               )*'     **.__     __.**     '*( 
               #  .==..__  """"   """"  __..==,  # 
               #   `""._(_).       .(_)_.""'   #
""");









        }
    }
}







//while ((!pnr.All(char.IsDigit)) || (pnr.Count(char.IsDigit) != 10)
//{
//    Console.WriteLine("Input your personal number below. (10 digits)");
//    Console.WriteLine("YYMMDDXXXX");
//    pnr = Console.ReadLine();
//}