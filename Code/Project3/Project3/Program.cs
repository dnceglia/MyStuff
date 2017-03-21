namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor john = new Instructor("john", "english");
            Instructor mike = new Instructor("mike", "math");
            Student jane = new Student("jane", john);
            Student joe = new Student("joe", john);
            Student melissa = new Student("melissa", mike);
            Student matt = new Student("matt", mike);

            john.SetStudentGrade(jane, 95);
            john.SetStudentGrade(joe, 85);
            mike.SetStudentGrade(melissa, 90);
            mike.SetStudentGrade(matt, 92);

            jane.printNameAndGrade();
            jane.printTeachersNameAndCourse();
            System.Console.WriteLine("");
            joe.printNameAndGrade();
            joe.printTeachersNameAndCourse();
            System.Console.WriteLine("");
            melissa.printNameAndGrade();
            melissa.printTeachersNameAndCourse();
            System.Console.WriteLine("");
            matt.printNameAndGrade();
            matt.printTeachersNameAndCourse();
            System.Console.WriteLine("");

            System.Console.Write("Press any key to continue... ");
            System.Console.ReadKey();
        }
    }
}
