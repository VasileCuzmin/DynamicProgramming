using System;

public class Program
{
    public static int CoinChange(int[] coins, int amount)
    {
        // Set an "impossible" value to act as our Infinity
        int maxVal = amount + 1;
        
        // Create our DP table (array) ranging from 0 to amount
        int[] dp = new int[amount + 1];
        
        // Fill the array with our "Infinity" value
        Array.Fill(dp, maxVal);
        
        // Base case: it takes 0 coins to make amount 0
        dp[0] = 0;

        // Build the table bottom-up, starting from amount 1
        for (int i = 1; i <= amount; i++)
        {
            // Test every coin we have for the current amount 'i'
            foreach (int coin in coins)
            {
                // Only use the coin if it isn't larger than the amount we are trying to make
                if (i - coin >= 0)
                {
                    // The DP Transition Equation
                    dp[i] = Math.Min(dp[i], 1 + dp[i - coin]);
                }
            }
        }

        // If the final answer is still our "impossible" value, we couldn't make the amount.
        return dp[amount] == maxVal ? -1 : dp[amount];
    }
}