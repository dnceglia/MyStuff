namespace _1050Project._._.I
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.Write("What is your first name? ");
            string firstName = System.Console.ReadLine();
            System.Console.Write("What is your middle initial? ");
            string middleInitial = System.Console.ReadLine();
            System.Console.Write("What is your last name? ");
            string lastName = System.Console.ReadLine();
            string fullName = firstName + " " + middleInitial + ". " + lastName;

            System.Console.Write("What is your height in feet? (4, 5, or 6)? ");
            int heightFeet = int.Parse(System.Console.ReadLine());
            System.Console.Write("And how many inches? ");
            double heightInches = double.Parse(System.Console.ReadLine());
            double fullHeightInInches = (heightFeet * 12) + heightInches;
            double totalHeightCM = 2.54 * fullHeightInInches;

            System.Console.Write("What is your age? ");
            int age = int.Parse(System.Console.ReadLine());
            System.Console.Write("Are you a United States Citizen (true or false)? ");
            bool isCitizen = bool.Parse(System.Console.ReadLine());
            bool canVote = isCitizen && age >= 18;

            System.Console.WriteLine("Your name is " + fullName + ".");
            System.Console.WriteLine("You are " + totalHeightCM + " CM tall.");
            System.Console.WriteLine("Your voter eligibility is " + canVote + ".");

            System.Threading.Thread.Sleep(5000);

        }
    }
}
