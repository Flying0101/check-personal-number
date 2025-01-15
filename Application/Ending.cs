namespace check_personal_nr
{
    public static class Ending
    {
        public static void TheEnd() // Why not                                    
        {
            Console.Clear();
            Console.WriteLine("Personal number accepted...");
            Console.WriteLine("Stealing your identity...");
            Thread.Sleep(1500);
            Console.Clear();
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
            // as program is so small we have used sleep
            Thread.Sleep(2000);
            ExitMove.Exit();
        }
    }
}

