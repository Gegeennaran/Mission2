namespace Mission2;

public class SecondClass
{
    //create an array that stores number for indexes 0 to 12
    private readonly int[] _totalCounts = new int[13];

    public void Simulate(int diceRoll)
    {
        //generate random number 
        Random random = new Random();

        //roll the dice "diceRoll" times
        for (int i = 0; i < diceRoll; i++)
        {
            //die 1 and 2 are each 1-6
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);
            int sum = die1 + die2;
            //increment the count in the array for that sum
            _totalCounts[sum]++;

        }
    }
//return the result 
    public int[] GetTotalCount()
    {
        return _totalCounts;
    }
}

    
