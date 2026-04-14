Let's use a perfect example where a "greedy" algorithm would fail, but our DP table will find the right answer.

Target Amount: 6

Coins Available: [1, 3, 4]

(Note: A greedy algorithm would pick the 4-cent coin first, leaving 2 cents, which requires two 1-cent coins. Total: 3 coins. But the actual best answer is two 3-cent coins! Let's see how the table proves this).


1. The Initial Setup

We create a 1D array (our table) where the indexes represent the target amounts from 0 up to 6.
We set dp[0] = 0 because it takes zero coins to make zero cents. We set every other amount to "Infinity" (∞) because we haven't found a way to make them yet.


Amount (Index i),0,1,2,3,4,5,6

Min Coins (dp[i]),0,∞,∞,∞,∞,∞,∞


2. Building the Table (Bottom-Up)
We will walk left-to-right, calculating the absolute best way to make each amount using the formula from earlier:

$$dp[i] = \min(dp[i], \quad 1 + dp[i - c])$$

Amount 1:

Try 1-cent coin: 1 + dp[0] -> 1 + 0 = 1.

(The 3 and 4 coins are too big).

Result: dp[1] = 1.

Amount 2:

Try 1-cent coin: 1 + dp[1] -> 1 + 1 = 2.

Result: dp[2] = 2.

Amount 3:

Try 1-cent coin: 1 + dp[2] -> 1 + 2 = 3.

Try 3-cent coin: 1 + dp[0] -> 1 + 0 = 1. (New record!)

Result: dp[3] = 1.

Amount 4:

Try 1-cent coin: 1 + dp[3] -> 1 + 1 = 2.

Try 3-cent coin: 1 + dp[1] -> 1 + 1 = 2.

Try 4-cent coin: 1 + dp[0] -> 1 + 0 = 1. (New record!)

Result: dp[4] = 1.

Amount 5:

Try 1-cent coin: 1 + dp[4] -> 1 + 1 = 2.

Try 3-cent coin: 1 + dp[2] -> 1 + 2 = 3.

Try 4-cent coin: 1 + dp[1] -> 1 + 1 = 2.

Result: dp[5] = 2.


3. The Grand Finale (Amount 6)
Here is what our table looks like right before we calculate our final target of 6:


Now we calculate amount 6 by looking back at our perfectly constructed cheat sheet:

Try 1-cent coin: Look back 1 space to dp[5]. The math is 1 + 2 = 3.

Try 3-cent coin: Look back 3 spaces to dp[3]. The math is 1 + 1 = 2. (New record!)

Try 4-cent coin: Look back 4 spaces to dp[2]. The math is 1 + 2 = 3.

The minimum is 2. The algorithm correctly figured out that skipping the largest coin (4) and using two 3-cent coins is the optimal answer!


Let's zoom in on the exact moment our program is trying to figure out Amount 4 (so, i = 4).
Our coins are [1, 3, 4].

Here is what our table looks like right before we calculate Amount 4. Notice that amounts 0 through 3 are already solved, and Amount 4 is currently set to Infinity (∞) because we haven't tested any coins yet.

Now, we run our formula for Amount 4. The formula is going to loop three times (once for each coin).

The formula is:

$$dp[4] = \min(dp[4], \quad 1 + dp[4 - c])$$

Here is exactly how the formula runs and updates the table during that loop:

Test 1: Using the 1-cent coin (c = 1)

We plug c = 1 into the formula:$$dp[4] = \min(\infty, \quad 1 + dp[4 - 1])$$
$$dp[4] = \min(\infty, \quad 1 + dp[3])$$

Now, the program looks at the table. What is dp[3]? The table says it's 1.$$dp[4] = \min(\infty, \quad 1 + 1)$$
$$dp[4] = \min(\infty, \quad 2)$$

Because 2 is smaller than infinity, 2 wins. The program erases the ∞ in the table and writes down 2.

Current Table State for Amount 4: dp[4] = 2

Test 2: Using the 3-cent coin (c = 3)

We plug c = 3 into the formula. Notice that dp[4] is now 2, not infinity!$$dp[4] = \min(2, \quad 1 + dp[4 - 3])$$
$$dp[4] = \min(2, \quad 1 + dp[1])$$

The program looks at the table. What is dp[1]? The table says it's 1.$$dp[4] = \min(2, \quad 1 + 1)$$
$$dp[4] = \min(2, \quad 2)$$

It’s a tie. The record doesn't change. The program leaves the table alone.

Current Table State for Amount 4: dp[4] = 2

Test 3: Using the 4-cent coin (c = 4)
We plug c = 4 into the formula.$$dp[4] = \min(2, \quad 1 + dp[4 - 4])$$
$$dp[4] = \min(2, \quad 1 + dp[0])$$


The program looks at the table. What is dp[0]? The table says it's 0.$$dp[4] = \min(2, \quad 1 + 0)$$
$$dp[4] = \min(2, \quad 1)$$

Because 1 is smaller than 2, 1 wins! The program erases the 2 in the table and writes down 1.

Final Table State for Amount 4: dp[4] = 1

The Result
The inner loop is now finished. The formula did its job by continually fighting to find the lowest possible number. The final answer is officially locked into the table:

Amount (Index i),0,1,2,3,4

Min Coins (dp[i]),0,1,2,1,1

Then, the program simply moves on to i = 5 and repeats this exact same battle!