namespace Project4Program
{
    class Program
    {
        static void Main(string[] args)
        {
            

            System.Console.WriteLine(" =================================================== ");
            System.Console.WriteLine(" ||                                               ||");
            System.Console.WriteLine(" ||  **   ** ****** **      ** ****** ***** ***** ||");
            System.Console.WriteLine(" ||  *** *** **  **  **    **    **   **    **    ||");
            System.Console.WriteLine(" ||  ** * ** **  **   **  **     **   ****  ***** ||");
            System.Console.WriteLine(" ||  **   ** **  **    ****      **   **       ** ||");
            System.Console.WriteLine(" ||  **   ** ******     **     ****** ***** ***** ||");
            System.Console.WriteLine(" ||                                               ||");
            System.Console.WriteLine(" =================================================== ");

            System.Console.Write("How many child matinee tickets would you like? ");
            double childMatineeQuantity = double.Parse(System.Console.ReadLine());

            System.Console.Write("How many adult matinee tickets would you like? ");
            double adultMatineeQuantity = double.Parse(System.Console.ReadLine());

            System.Console.Write("How many senior matinee tickets would you like? ");
            double seniorMatineeQuantity = double.Parse(System.Console.ReadLine());

            System.Console.Write("How many child evening tickets would you like? ");
            double childEveningQuantity = double.Parse(System.Console.ReadLine());

            System.Console.Write("How many adult evening tickets would you like? ");
            double adultEveningQuantity = double.Parse(System.Console.ReadLine());

            System.Console.Write("How many senior evening tickets would you like? ");
            double seniorEveningQuantity = double.Parse(System.Console.ReadLine());

            System.Console.Write("How many small drinks would you like? ");
            int smallDrinkQuantity = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many large drinks would you like? ");
            int largeDrinkQuantity = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many hot dogs would you like? ");
            int weinerQuantity = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many bags of popcorn would you like? ");
            int popcornQuantity = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many boxes of candy would you like? ");
            int candyQuantity = int.Parse(System.Console.ReadLine());

            double totalPrice = 0;
            int minimumQuantity = 0;
            int freeCandyQuantity = 0;

            totalPrice += childMatineeQuantity * 3.99;
            totalPrice += adultMatineeQuantity * 5.99;
            totalPrice += seniorMatineeQuantity * 4.50;
            totalPrice += childEveningQuantity * 6.99;
            totalPrice += adultEveningQuantity * 10.99;
            totalPrice += seniorEveningQuantity * 8.50;
            totalPrice += smallDrinkQuantity * 3.50;
            totalPrice += largeDrinkQuantity * 5.99;
            totalPrice += weinerQuantity * 3.99;
            totalPrice += popcornQuantity * 4.50;
            totalPrice += candyQuantity * 1.99;

            if (candyQuantity >= 3)
            {
                freeCandyQuantity = candyQuantity / 4;
            }

            if (popcornQuantity < largeDrinkQuantity)
            {
                minimumQuantity = popcornQuantity;
            }
            else
            {
                minimumQuantity = largeDrinkQuantity;
            }

            double dosDollarDiscount = minimumQuantity * 2.00;
            totalPrice -= dosDollarDiscount;

            totalPrice -= freeCandyQuantity * 1.99;

            System.Console.WriteLine("");
            System.Console.WriteLine("Your movie trip cost: " + totalPrice);
            System.Console.Write("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
