# DynamicProgramming
https://medium.com/strategio/dynamic-programming-is-not-as-complicated-as-you-thought-leetcode-322-coin-change-8745ca303433

https://www.youtube.com/watch?v=W2ote4jCuYw&list=PLyEvk8ZeQDMVbsg7CEfT0NV3s3GkMx1vN&index=1

Figuring out whether a problem can be solved with Dynamic Programming (DP) is often the hardest part of the entire process! You are completely right to focus on the DP State and the DP Transition Equation.

To know if a problem allows you to define those two things, computer scientists look for two foundational mathematical characteristics. If a problem has both of these, it is guaranteed to be a DP problem.

Figuring out whether a problem can be solved with Dynamic Programming (DP) is often the hardest part of the entire process! You are completely right to focus on the DP State and the DP Transition Equation.To know if a problem allows you to define those two things, computer scientists look for two foundational mathematical characteristics. If a problem has both of these, it is guaranteed to be a DP problem.
1. The Two Golden Rules of DP.
To use DP, your problem must exhibit these two properties:
A. Overlapping Subproblems (The "Deja Vu" Rule)Does the problem force you to calculate the exact same thing multiple times?Think back to the Fibonacci sequence. To calculate $F(5)$, you need $F(4)$ and $F(3)$. To calculate $F(4)$, you need $F(3)$ and $F(2)$. Notice how we are asked to calculate $F(3)$ twice?If a problem can be broken down into smaller pieces, and those identical pieces show up over and over again, you have overlapping subproblems. This tells you that caching (memoization/tabulation) will actually be useful.



2. How this connects to "State" and "Transition"
If you confirm the two rules above, you can confidently build your DP solution using the two concepts you mentioned:

Defining the DP State: Can you "freeze time" during the problem and describe your exact situation using just one or two variables?

Example: "I am at step i on the staircase, and I have k stamina left." -> Your state is dp[i][k].

If you have to remember the entire history of every choice you made to get there, the state is too complex for DP.

Finding the DP Transition Equation: Can you write a mathematical formula that links your current state to your previous states?

DP almost always involves making a choice at every step. The equation usually looks like taking the max() or min() of those choices.

Example: "At step i, I either arrived from one step below, or two steps below." -> dp[i] = dp[i-1] + dp[i-2].




3. The Practical "Cheat Sheet" (Keywords to look for)
When reading an algorithm question or a real-world coding task, look for these specific trigger phrases. They are massive red flags that DP is the intended solution:

Optimization: "Find the maximum profit", "Find the minimum cost", "What is the shortest...", "What is the longest..."

Counting ways: "How many distinct ways can you...", "Find the total number of paths..."

Sequence/String matching: Problems involving "subsequences," "substrings," or comparing two different strings (like finding the longest common characters between them).

Constraints: If the problem asks you to make choices under a strict limit (e.g., "You have a backpack that holds exactly 15 pounds, maximize the value of the items you put in it").