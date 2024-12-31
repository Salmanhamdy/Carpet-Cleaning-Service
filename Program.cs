namespace task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task
            /*
             *     Islam's Carpet Cleaning Service
          Charges:
              $25 per small
              $35 per large
          Sales tax rate is 6%
          Estimates are valid for 30 days
         
          Prompt the user for the number of small and large rooms they would like cleaned
          and provide an estimate such as:
     
         Estimate for carpet cleaning service
         Number of small carpets: 3 <--
         Number of large carpets: 1 <--
         Price per small room: $25
         Price per large room: $35
         Cost : $110
         Tax: $6.6
         ===============================
         Total estimate: $116.6
         This estimate is valid for 30 days
             * */
            #endregion
            Console.WriteLine("========================================");
            Console.WriteLine("welcome  Islam's Carpet Cleaning Service");
            Console.WriteLine("========================================");
            Console.WriteLine(" Charges:\r\n              $25 per small\r\n              $35 per large\r\n          Sales tax rate is 6%\r\n          Estimates are valid for 30 days");

            int numberofsmall, numberoflarge;
            Console.WriteLine("please enter Number of small carpets: ");
            numberofsmall=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter Number of large carpets: ");
            numberoflarge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" Price per small room: 25$");
            Console.WriteLine($" Price per large room: 35$");
            int cost = (numberofsmall * 25) + (numberoflarge * 35);
            Console.WriteLine($"cost:{cost}");
            float tax = cost * 0.06f;
            Console.WriteLine($"tax:{tax}");
            Console.WriteLine("===================================");
            Console.WriteLine($" Total estimate: ${cost+tax}\r\n         This estimate is valid for 30 days");

        }
    }
}
