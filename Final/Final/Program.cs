namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator1 = new Elevator(2, 400);
            Passenger firstOccupant = new Passenger("A1", 180);
            Passenger secondOccupant = new Passenger("A2", 220);
            elevator1.AddOccupant(firstOccupant, 0);
            elevator1.AddOccupant(secondOccupant, 1);
            bool elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();

            Elevator elevator2 = new Elevator(3, 600);
            Passenger thirdOccupant = new Passenger("A1", 200);
            Passenger fourthOccupant = new Passenger("A2", 200);
            Passenger fifthOccupant = new Passenger("A3", 201);
            elevator2.AddOccupant(thirdOccupant, 0);
            elevator2.AddOccupant(fourthOccupant, 1);
            elevator2.AddOccupant(fifthOccupant, 2);
            bool elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity();

        }
    }
}
