namespace Project_deuce
{
    class Program
    {
        static void Main(string[] args)
        {

            Person somePerson = new Person();

            somePerson.firstName = "John";
            somePerson.lastName = "Doe";
            somePerson.age = 34;
            // somePerson.spouse = ;           // needs completed

            somePerson.firstName = "Jane";
            somePerson.lastName = "Doe";
            somePerson.age = 22;
            // somePerson.spouse = ;           // needs completed

            somePerson.firstName = "David";
            somePerson.lastName = "Smith";
            somePerson.age = 76;
            // somePerson.spouse = ;           // needs completed

            somePerson.firstName = "Dora";
            somePerson.lastName = "Smith";
            somePerson.age = 64;
            // somePerson.spouse = ;           // needs completed

            ////////////////////////////////   option 2   //////////////////////////////////////////

            Person p1 = new Person();

            System.Console.Write("What is your first name? ");
            p1.firstName = "John";                              // do you declare variables for age, name etc. like this
            // spousal question
            System.Console.Write("What is your last name? ");
            p1.lastName = System.Console.ReadLine();            // or like this
            System.Console.Write("How old are you? ");
            p1.age = 34;
            System.Console.Write("What is your spouse's first name? ");
            // p1.spouse = xxxxx;


            Person p2 = new Person();
            p2.firstName = "Jane";
            p2.lastName = "Doe";
            p2.age = 22;
            // p2.spouse = xxx;

            // System.Console.WriteLine(p1.StateYourNameAndAge()); 
            // System.Console.WriteLine(p2.StateYourNameAndAge());

            // Average age formula and output ..... here.....

            // System.Threading.Thread.Sleep(5000);

            ///////////////////////////////////          or          /////////////////////////////////

            // System.Console.WriteLine("Press any key to continue...");
            // System.Console.ReadKey();



            //////////////////////////////   user input    ///////////////////////////////////////////

            System.Console.Write("What is your name? ");
            System.Console.Write("How old are you? ");
            System.Console.Write("What is your marital status? ");
            System.Console.Write("What is the first name of your spouse? ");
            System.Console.Write("What is the age of your spouse? ");

        }
    }
}
