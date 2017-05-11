namespace Project3
{
    class Instructor
    {
        private string name;
        private string courseName;

        public Instructor(string name, string courseName)
        {
            this.name = name;
            this.courseName = courseName;
        }

        public void SetStudentGrade(Student studentsname, int grade)
        {
            studentsname.SetGrade(grade);
        }
        
        public void PrintInstructorInfo()
        {
            System.Console.WriteLine(name);
            System.Console.WriteLine(courseName);
        }

        public void teachersNameAndCourse()
        {
            System.Console.WriteLine("Teacher: " + name);
            System.Console.WriteLine("Course: " + courseName);
        }
    }
}
