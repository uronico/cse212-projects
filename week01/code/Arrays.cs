public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create an array of doubles with the given length.
        // Step 2: Use a loop to fill the array.
        // Step 3: For each index i (from 0 to length-1), set the value to number * (i + 1).
        // Step 4: After the loop, return the filled array.

        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
        multiples[i] = number * (i + 1);
        }
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Determine the number of elements in the list (data.Count).
        // Step 2: Calculate the split point. The last 'amount' elements will move to the front.
        //         The split point is at index (data.Count - amount).
        // Step 3: Use GetRange to get the last 'amount' elements.
        // Step 4: Use GetRange to get the first (data.Count - amount) elements.
        // Step 5: Clear the original list.
        // Step 6: Add the last 'amount' elements to the list.
        // Step 7: Add the first (data.Count - amount) elements to the list.
        // Step 8: The list is now rotated to the right by 'amount'.

        int n = data.Count;
        int split = n - amount;

        List<int> rightPart = data.GetRange(split, amount);
        List<int> leftPart = data.GetRange(0, split);

        data.Clear();
        data.AddRange(rightPart);
        data.AddRange(leftPart);
    }
}
