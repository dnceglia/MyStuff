namespace ExampleFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declared a local variable of type Circle.
            // Insantiated a new Circle object with a radius of 2.5.
            // Assigned the variable circle1 the location of the new Circle.
            Circle circle1 = new Circle(2.5);

            // Another circle...
            Circle circle2 = new Circle(3.0);

            // Invoked a public method from a local instance of a Circle object.
            double area1 = circle1.GetArea();

            // Invoked a public method from a local instance of another Circle object.
            double area2 = circle2.GetArea();

            // Invoked a public void method and passed a literal value of 5 as a parameter.
            circle2.SetRadius(5);
            double circle2NewArea = circle2.GetArea();

            // This is a random number generator.
            System.Random randomNumberGenerator = new System.Random();

            // Declared an array of circles.
            // Instatiated memory for the array to contain 10 positions.
            // (Don't have any actual circles yet, just an array)
            Circle[] circles = new Circle[10];

            // For loop iterated 10 times.
            // Instantiated 10 Circle Objects.
            // Each Object exists at an index of the array.
            for (int i = 0; i < 10; i++)
            {
                int randomInt = randomNumberGenerator.Next(1, 9);
                circles[i] = new Circle(randomInt);
            }
            
            // For each loop iterates through each circle in the array.
            foreach (Circle circle in circles)
            {
                System.Console.Write(circle.GetRadius() + " ");
                System.Console.WriteLine(circle.GetArea());
            }

            System.Console.ReadKey();
        }
    }
}