// See https://aka.ms/new-console-template for more information
//Gegeennaran Enkhtuvshin 
//section 3
namespace Mission2;

internal class Program
{
    public static void Main(string[] args)
    {
        //welcome message
        Console.WriteLine("Welcome to the dice throwing simulator!");
        
        //ask user input for diceRoll count
        Console.WriteLine("How many dice rolls would you like to simulate?: ");
        
        //convert user input to an integer
        int diceRoll = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("No input was provided"));
        
        //connect to the SecondClass
        SecondClass sc = new SecondClass();
        sc.Simulate(diceRoll);
        
        //get the result from SecondClass
        int[] results = sc.GetTotalCount();
        
        //print the result
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS\n Each \"*\" " +
                          "represents 1% of the total number of rolls.\n Total number of rolls= " + diceRoll);
        
        //loop through each number in the result array and calculate the percentage and print asterisks histogram 
        for (int sum = 2; sum <= 12; sum++)
        {
            //count the result for each numbers
            int count = results[sum];
            
            //calculate the percentage (check if the diceroll is not 0; if 0 default to 0.0 result)
            double percentage = (diceRoll > 0)
                ? (double)count / diceRoll * 100
                : 0.0;
            
            // Create the histogram bar as asterisks
            int starCount = (int)Math.Round(percentage);
            
            // Build the string of asterisks
            string stars = new string('*', starCount);
            
            Console.WriteLine($"{sum}: {stars}");
        }
        
        //end the program
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        Console.ReadKey();
        
    }
}