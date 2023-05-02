namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Program");
            Console.WriteLine("1:Flip coinn\n2:Leap Year\n3:Power of two");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoinUC1 flipCoin = new FlipCoinUC1();
                    flipCoin.FlipCoins();
                    break;
                case 2:
                    LeapYearUC2 leapYear = new LeapYearUC2();
                    leapYear.LeapYears();
                    break;
                case 3:
                    PowerOfTwoUC3 powerOfTwo = new PowerOfTwoUC3();
                    powerOfTwo.PowerOf2();
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}