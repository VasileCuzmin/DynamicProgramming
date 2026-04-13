
https://www.youtube.com/watch?v=H9bfqozjoqs  


You are given an integer array coins representing coins of different denominations and an integer amount representing a total amount of money.

Return the fewest number of coins that you need to make up that amount. If that amount of money cannot be made up by any combination of the coins, return -1.

You may assume that you have an infinite number of each kind of coin.

In short: we want to know the fewest number of coins, with a given coin selection, when we want to get a specific amount.

Here are some examples:

Example 1

Input: coins = [1,2,5], amount = 11
Output: 3
Explanation: 11 = 5 + 5 + 1

Since we have coins denominated at 1, 2, and 5, for an amount of 11, 5+5+1 will be the changing method resulting in the fewest coins. We could, of course, quickly come up with other solutions, like 2 + 2 + 2 + 2 + 2 + 1 or 11 * 1, but none of them could make the number 3.

Example 2

Input: coins = [2], amount = 3
Output: -1
In this case, we only have coins denominated at 2, but the total amount is 3. So we could quickly know that this amount is impossible for such coins (unless half of a coin is a legal tender in this society… but now it’s not), so the output should be -1 since it means “impossible”.

Example 3

Input: coins = [1], amount = 0
Output: 0
This is also easy to understand. When the expected amount is 0, no matter what kind of coins we have, the fewest number will be 0.


Coin Change is a fantastic problem because it is actually simpler than the 0/1 Knapsack problem. You only need a 1D array instead of a 2D table!

There are two versions of this problem. We are going to look at the most common one: Find the minimum number of coins needed to make a specific amount. (You have an infinite supply of each coin denomination).

Here are the DP State and the Transition Equation.


1. The DP State
In the Knapsack problem, we had to track both the item we were looking at and the weight left.
In Coin Change, because we have an infinite supply of coins, we don't care which coin we are "currently" looking at. We only care about one thing: the amount we are trying to make.

Because we only track one variable, our DP cache is just a flat, 1D array.

The State: Let dp[i] represent the absolute minimum number of coins needed to make the exact amount i.


2. The DP Transition EquationImagine your target amount is 11, and you have three coins: [1, 2, 5].If you are trying to figure out dp[11], you just look at your coins and ask, "If I use this coin, what amount am I left with?"If you use a 1 coin, you are left needing 10. The total coins used would be $1 + dp[10]$.If you use a 2 coin, you are left needing 9. The total coins used would be $1 + dp[9]$.If you use a 5 coin, you are left needing 6. The total coins used would be $1 + dp[6]$.



To find the best answer for 11, you just check your cheat sheet (the array) for those smaller amounts and take the absolute minimum of those choices!

The Transition Equation:

For every amount i, and for every coin c in your list of coins (where $i \ge c$):$$dp[i] = \min(dp[i], \quad 1 + dp[i - c])$$


$dp[i]$: The best answer we've found so far for this amount.

$1$: Represents the single coin c we just decided to use.

$dp[i - c]$: The perfect, pre-calculated answer for the remaining amount.


To solve the whole problem, you start at dp[0] = 0 (it takes 0 coins to make amount 0), and you use a loop to build your way up to your target amount.