namespace Age_Average_question___Project_2{
    class Program
    {
        static void Main(string[] args)
        {
            
            //////////////////////////   Person Class   ///////////////////////
            
            public int Age;
            public Person Spouse;
            public static int AgeCount;
            public static int SumOfAllAges;

        public void StateYourMaritalStatus()
        {
            System.Console.WriteLine("What is your spouse's first name? ");
            this.Spouse.FirstName = System.Console.ReadLine();
            this.Spouse.LastName = this.LastName;

            System.Console.WriteLine("How old are they? ");
            this.Spouse.Age = int.Parse(System.Console.ReadLine());

            //////////////////////////////////////////////////////////////////////
            /////////////////////////////  1st try   /////////////////////////////

            Person.AgeCount++;
            Person.SumOfAllAges += this.Age;

            // average returned lowest p1 age input?
            //////////////////////////////////////////////////////////////////////
            /////////////////////////////   2nd try   ////////////////////////////

            Person.AgeCount++;
            Person.SumOfAllAges += this.Age;
            Person.SumOfAllAges += this.Spouse.Age;

            // average returned spouses ages added together then divided?
            //////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////
        }

        public static double AgeAverage()
        {
            return Person.SumOfAllAges / Person.AgeCount;
        }
    }
    }
}
