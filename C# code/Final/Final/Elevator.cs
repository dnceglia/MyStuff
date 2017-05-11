namespace Final
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;
        private double sumOfAllWeights;

        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            MaxWeight = maxWeight;
        }

        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
            sumOfAllWeights += Occupants[index].GetWeight();
        }

        public double GetCurrentWeight()
        {
            return sumOfAllWeights;
        }

        public bool IsOverMaxCapacity()
        {
            return GetCurrentWeight() > MaxWeight;
        }      
    }
}
