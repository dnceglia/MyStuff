namespace Project_deuce
{
    class Person
    {

        public int age;
        public string firstName;
        public string lastName;
        public Person spouse;

        public string getFullName()
        {

        }

        public string printNameAndAge()
        {
            return this.firstName + this.lastName + " (" + // Person.age + ")";
        }

    }
}
