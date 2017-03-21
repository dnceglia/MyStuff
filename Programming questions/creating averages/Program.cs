namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Thing thing1 = new Thing();
            Thing.Count++;

            Thing thing2 = new Thing();
            Thing.Count++;

            Thing thing3 = new Thing();
            Thing.Count++;

            thing1.Weight = 100;
            thing2.Weight = 200;
            thing3.Weight = 300;

            double totalWeight = thing1.Weight + thing2.Weight + thing3.Weight;
            double averageWeight = totalWeight / Thing.Count;
        }
    }
}