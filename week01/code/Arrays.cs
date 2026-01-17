public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    /// 
    /// <MultiplesOf function Plan>
    /// create an array with a size equal to the number of multiples
    /// Loop througj the array 
    /// For each index, calculate the multiple
    /// Store the calculated value in the array 
    /// Return the array 
    public static double[] MultiplesOf(double number, int length)
    {
        //create an array with a size equal to the number of multiples
        double[] numbers = new double[length];

        // Loop through the array 
        for (int i = 0; i < length; i++)
        {
            // Store the calculated value 
            numbers[i] = number * (i + 1);
        }

        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        return numbers; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    /// 
    /// <Plans>
    /// Find the index where the last 'amount' elements start
    /// Copy the last 'amount' elements into a temporary list
    /// Remove the last 'amount' elements from the original list
    /// Insert the copied elements at the beginning of the list
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Find where the last 'amount' elements begin
        int startIndex = data.Count - amount;

        // Step 2: Copy the last 'amount' elements
        List<int> temp = data.GetRange(startIndex, amount);

        // Remove the last 'amount' elements from the original list
        data.RemoveRange(startIndex, amount);

        //Insert those elements at the front of the list
        data.InsertRange(0, temp);
        
    }
}
