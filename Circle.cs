namespace ExampleFinal
{
    // Defined a class.
    public class Circle
    {
        // Declared a member variable.
        private double radius;
        
        // Constructor - Method with no return
        // type and the same name as the class.
        // Also, we want to pass a double value
        // to initialize the radius of the circle.
        public Circle(double r)
        {
            this.radius = r;
        }

        // Declared a non-void method with no parameters.
        // Method returns the value of the radius member variable.
        public double GetRadius()
        {
            return this.radius;
        }

        // Declared a non-void method with no parameters.
        // Method returns a double which is the area of the Circle.
        public double GetArea()
        {
            double rSquared = this.radius * this.radius;
            return System.Math.PI * rSquared;
        }

        // Declared a void method with 1 parameter of type double.
        // Method does not return anything--It just sets the object's radius.
        public void SetRadius(double r)
        {
            this.radius = r;
        }
    }
}