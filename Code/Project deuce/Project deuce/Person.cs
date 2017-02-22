namespace Project_deuce
{
    class Person
    {

        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;
        public static int AgeCount;
        public static int SumOfAllAges;

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(GetFullName() + " is " + this.Age + " years old.");
        }

        public void StateYourNameAndAge()
        {
            System.Console.WriteLine("What is your first name? ");
            this.FirstName = System.Console.ReadLine();

            System.Console.WriteLine("What is your last name? ");
            this.LastName = System.Console.ReadLine();

            System.Console.WriteLine("How old are you? ");
            this.Age = int.Parse (System.Console.ReadLine());
        }

        public void StateYourMaritalStatus()
        {
            System.Console.WriteLine("What is your spouse's first name if you're married? ");
            this.Spouse.FirstName = System.Console.ReadLine();
            this.Spouse.LastName = this.LastName;

            System.Console.WriteLine("How old are they? ");
            this.Spouse.Age = int.Parse(System.Console.ReadLine());

            Person.AgeCount++;
            Person.SumOfAllAges += Age;
        }

        public static double AgeAverage()
        {
            return Person.SumOfAllAges / Person.AgeCount;
        }

        public void PrintAverageAge()
        {
            System.Console.WriteLine("Your average age is " + AgeAverage() + " years old.");
        }
    }
}
