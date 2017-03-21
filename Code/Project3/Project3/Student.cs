namespace Project3
{
    class Student
    {
        private string name;
        private int grade;
        private Instructor teacher;

        public Student(string studentName, Instructor teacherClass)
        {
            this.name = studentName;
            this.grade = 0;
            this.teacher = teacherClass;
        }

       public void SetGrade(int grade)
       {
            this.grade = grade;
       }

        public void printNameAndGrade()
        {
            System.Console.WriteLine("Students Name: " + name);
            System.Console.WriteLine("Students Grade: " + grade);
        }

        public void printTeachersNameAndCourse()
        {
            teacher.teachersNameAndCourse();
        }
    }
}
