namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Islam's Carpet Cleaning Service\r\n " +
                "   Charges:\n" +
                "        $25 per small\n " +
                "       $35 per large\n  " +
                "  Sales tax rate is 6%\n " +
                "   Estimates are valid for 30 days\n");
            Console.WriteLine("Number of small carpets");
            int smallCarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of large carpets");
            int largeCarpets = Convert.ToInt32(Console.ReadLine());
            double total = (smallCarpets * 25) + (largeCarpets * 35);
            double tax= (total * 6) / 100;
            Console.WriteLine($"cost:{total}");
            Console.WriteLine($"Tax :{tax}");
            Console.WriteLine($"Total estimate:{total + tax}");
            Console.WriteLine("This estimate is valid for 30 days\n");


        }
    }
}
