https://leetcode.com/discuss/post/3722472/sliding-window-technique-a-comprehensive-ix2k/

1.Fixed Window:

In a fixed window problem, we have a predefined window size that remains constant throughout the problem-solving process.
The template for solving a fixed window problem involves maintaining two pointers, low and high, that represent the indices of the current window.
The process involves iterating over the array or sequence, adjusting the window as necessary, and performing computations or operations on the elements within the window.
Here's the template

```
fixed_window()
{
    int low = 0, high = 0, windowsize = k;
    while (i < sizeofarray)
    {
        // Step 1: Create a window that is one element smaller than the desired window size
        if (high - low + 1 < windowsize)
        {
            // Generate the window by increasing the high index
            high++;
        }
        // Step 2: Process the window
        else
        {
            // Window size is now equal to the desired window size
            // Step 2a: Calculate the answer based on the elements in the window
            // Step 2b: Remove the oldest element (at low index) from the window for the next window

            // Proceed to the next window by incrementing the low and high indices
        }
    }
}
```


Example on above Format

Q->Given an array arr[] and an integer K, the task is to calculate the sum of all subarrays of size K.

```
function printWindowSums(v, k) {
    let n = v.length;
    let i = 0; // Left pointer of the window
    let j = 0; // Right pointer of the window
    let sum = 0; // Current window sum

    while (j < n) {
        // Calculate the current window size
        let windowSize = j - i + 1;

        if (windowSize < k) {
            // Expand the window by adding element at index j to the sum
            sum += v[j];
            j++;
        } 
        else {
            // Window size is exactly k
            // Add the final element of this window
            sum += v[j];
            
            // Output the answer for this specific window
            console.log(sum);

            // Slide the window forward:
            // 1. Subtract the element that is falling out of the window (left side)
            sum -= v[i];
            
            // 2. Move both boundaries to the right
            i++;
            j++;
        }
    }
}

// Let's test it!
// Array of size 7, looking for windows of size 3
const arr = [1, 2, 3, 4, 5, 6, 7];
printWindowSums(arr, 3);
```


```
function CalculateMaxWindowSum(v, k) {
    let n = v.length;
    let i = 0; // Left pointer of the window
    let j = 0; // Right pointer of the window
    let sum = 0; // Current window sum
    let maxSum = 0;

    while (j < n) {
        // Calculate the current window size
        let windowSize = j - i + 1;

        if (windowSize < k) {
            // Expand the window by adding element at index j to the sum
            sum += v[j];
            j++;
        } 
        else {
            // Window size is exactly k
            // Add the final element of this window
            sum += v[j];

             maxSum = Math.max(sum,maxSum);
            
            // Output the answer for this specific window
            console.log(sum);

            // Slide the window forward:
            // 1. Subtract the element that is falling out of the window (left side)
            sum -= v[i];
            
            // 2. Move both boundaries to the right
            i++;
            j++;
        }
    }

    return maxSum;
}

// Let's test it!
// Array of size 7, looking for windows of size 3
const arr = [1, 2, 3, 4, 5, 6, 7];
var result = CalculateMaxWindowSum(arr, 3);//5+6+7 = 18
```



2. Variable Window

In a variable window problem,the window size is not fixed and can change dynamically based on certain conditions or criteria. The template for solving a variable window problem involves maintaining two pointers, start and end, which represent the indices of the current window.

Initialize the window indices: Start by initializing the start and end pointers to the first element of the sequence or array.

Expand the window: Check a condition to determine whether to expand the window. If the condition is satisfied, increment the end pointer to expand the window size.

Process the window: Once the window size meets the desired criteria or condition, perform the required computations or operations on the elements within the window.

Adjust the window size: If the window size exceeds the desired criteria, adjust the window by moving the start pointer. Iterate or loop until the window size matches the desired criteria, and update the window accordingly.

```
variable_window()
{
    int start = 0, end = 0;
    while (end < n)
    {
        // Perform calculations or operations within the window

        /* Case 1: Expand the window
           If the window size is less than the desired value (k), increase the end index
        */
        if (end - start + 1 < k)
        {
            end++;
        }

        /* Case 2: Window of desired size
           If the window size is equal to the desired value (k), process the window and calculate the answer
        */
        else if (end - start + 1 == k)
        {
            // Perform the required calculations or operations to obtain the answer
            // Store the answer in a variable (ans)

            end++;
        }

        /* Case 3: Reduce the window size
           If the window size is greater than the desired value (k), adjust the window by moving the start index
        */
        else if (end - start + 1 > k)
        {
            while (end - start + 1 > k)
            {
                // Remove calculations or operations involving the element at the start index

                start++;
            }

            // Check if the window size becomes equal to the desired value (k) after adjustment
            if (end - start + 1 == k)
            {
                // Perform calculations or operations and store the answer if necessary
            }

            end++;
        }
    }

    // Return the final answer (ans)
}
```


Ex: Longest-substring-without-repeating-characters

```
function lengthOfLongestSubstring(s) {
    // A Set is a special JavaScript object that only stores UNIQUE values.
    // It's our "magical box" to keep track of the letters we've seen.
    let seenLetters = new Set(); 
    
    let left = 0;       // This points to the start of our current substring
    let maxLength = 0;  // This keeps track of the longest length we've found

    // The 'right' pointer goes through the string one letter at a time
    for (let right = 0; right < s.length; right++) {
        let currentLetter = s[right];

        // Step 1: Check for duplicates
        // If our box already has this letter, we must shrink our window from the left.
        while (seenLetters.has(currentLetter)) {
            // Remove the leftmost letter from the box
            seenLetters.delete(s[left]); 
            // Move our left pointer forward by 1
            left++; 
        }

        // Step 2: Add the new letter
        // Now that there are no duplicates, it's safe to add the new letter.
        seenLetters.add(currentLetter);

        // Step 3: Update the max length
        // The size of our current window is (right - left + 1)
        let currentWindowSize = right - left + 1;
        
        // If our current window is bigger than our previous record, update it!
        if (currentWindowSize > maxLength) {
            maxLength = currentWindowSize;
        }
    }

    return maxLength;
}

// You can test it in your console:
console.log(lengthOfLongestSubstring("abcabcbb")); // Outputs: 3
console.log(lengthOfLongestSubstring("abcabcbb")); // Output: 3 ("abc")
console.log(lengthOfLongestSubstring("bbbbb"));    // Output: 1 ("b")
console.log(lengthOfLongestSubstring("pwwkew"));   // Output: 3 ("wke")
```


```
Beginner Concepts Used Here:
new Set(): Beginners often use Arrays [] to store lists of things. But Arrays allow duplicates (like ['a', 'a']). A Set is a built-in JavaScript tool that automatically prevents duplicates. We use seenLetters.has(letter) to check if a letter is inside, and seenLetters.delete(letter) to remove one.

The while loop: We use an if statement when we want to do something once. We use a while loop here because if we hit a duplicate, we might need to remove multiple letters from the left before the duplicate is finally gone.

The Math (right - left + 1): This is a standard formula in programming to find the distance between two indices. For example, if left is at index 0 and right is at index 2 (covering letters at 0, 1, and 2), the math is 2 - 0 + 1 = 3 total letters.

```

```
Setup
Word (s): "aba"

Magical Box (seenLetters): { } (empty Set)

left pointer: 0

maxLength: 0

Step 1: Looking at the first letter
right pointer: 0

Current letter: 'a'

Action: Is 'a' in our box? No.

We put 'a' in the box.

Our current window size is 1.

State Updates:

seenLetters: { 'a' }

maxLength: 1

Step 2: Looking at the second letter
right pointer: 1

Current letter: 'b'

Action: Is 'b' in our box? No.

We put 'b' in the box.

Our current window size is 2 (the letters "ab").

State Updates:

seenLetters: { 'a', 'b' }

maxLength: 2

Step 3: Looking at the third letter (The Tricky Part!)
right pointer: 2

Current letter: 'a'

Action: Is 'a' in our box? Yes! We have a duplicate.

Enter the while loop! We must shrink our window from the left until that old 'a' is gone.

We look at the letter at our left pointer (which is index 0, the first 'a').

We take that first 'a' out of the box.

We move our left pointer forward by 1 (so left is now 1).

Now the box only has {'b'}. The duplicate 'a' is gone! Exit the while loop.

Now it is safe to put our NEW 'a' into the box.

Our current window size is 2 (the letters "ba", from index 1 to 2).

State Updates:

seenLetters: { 'b', 'a' }

left: 1

maxLength: remains 2

We reached the end of the word, and our code outputs 2.
```


Run the alg below here: https://algorithm-visualizer.org/scratch-paper/new



```

const { Tracer, Array1DTracer,LogTracer, Array2DTracer, ChartTracer, Randomize, Layout, VerticalLayout } = require('algorithm-visualizer');


const tracer = new Array1DTracer("Set")
const logTracer = new LogTracer("Console")

const messages = [
  'Visualize',
  'your',
  'own',
  'code',
  'here!',
];

// highlight each line of messages recursively
function highlight(line) {
  if (line >= messages.length) return;
  const message = messages[line];
  // visualize {
  logTracer.println(message);
  //array2dTracer.selectRow(line, 0, message.length - 1);
  Tracer.delay();
 // array2dTracer.deselectRow(line, 0, message.length - 1);
  // }
  highlight(line + 1);
}

function printWindowSums(v, k) {
    let n = v.length;
    let i = 0; // Left pointer of the window
    let j = 0; // Right pointer of the window
    let sum = 0; // Current window sum
    let maxSum = 0;
    
    while (j < n) 
    {
        // Calculate the current window size
        let windowSize = j - i + 1;
        
         // visualize {
           Tracer.delay();
           logTracer.println("i=" + i + " " + "j=" + j)
           logTracer.println("windowSize "+ windowSize)
  tracer.select(i,j);
  Tracer.delay();
  // }

        if (windowSize < k) {
            Tracer.delay();
            // Expand the window by adding element at index j to the sum
            sum += v[j];
            j++;
        } 
        else {
           
              
            // Window size is exactly k
            // Add the final element of this window
            sum += v[j];
            
            // Output the answer for this specific window
            logTracer.println("sum " + sum);
            
            
            maxSum = Math.max(sum,maxSum);

            
            logTracer.println("maxSum " + maxSum);

            // Slide the window forward:
            // 1. Subtract the element that is falling out of the window (left side)
            sum -= v[i];
             Tracer.delay();
            tracer.deselect(i);
            Tracer.delay();
            
            // 2. Move both boundaries to the right
            i++;
            j++;
        }
    }
    
    return maxSum;
}

(function main() {
    
      const arr = [3,2,325,6,1,9,-1,4,34,1,-4,9,3,4,-67,90];


  // visualize {
  Layout.setRoot(new VerticalLayout([tracer, logTracer]));
  tracer.set(arr);
  //array2dTracer.set(messages);
  Tracer.delay();
  
  
  // }
  
var maxSum = printWindowSums(arr, 5);
logTracer.println("max sum " + maxSum);

  //highlight(0);
})();


```
