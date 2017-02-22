namespace Project_deuce
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.Spouse = new Person();
            p1.StateYourNameAndAge();
            p1.StateYourMaritalStatus(); 

            Person p2 = new Person();
            p2.Spouse = new Person();
            p2.StateYourNameAndAge();
            p2.StateYourMaritalStatus();

            p1.PrintNameAndAge();
            p1.Spouse.PrintNameAndAge();
            p2.PrintNameAndAge();
            p2.Spouse.PrintNameAndAge();
            // PrintAverageAge();
            // System.Console.WriteLine("Your average age is " + Person.AgeAverage() + " years old.");

            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();

        }
    }
}
