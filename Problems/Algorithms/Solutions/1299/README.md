# 1299. Replace Elements with Greatest Element on Right Side

### Desctription

Given an array `arr`, replace every element in that array with the greatest element among the elements to its right, and replace the last element with '-1'.

After doing so, return the array.

### Example

#### **Example 1:**

```
Input: arr = [17,18,5,4,6,1]
Output: [18,6,6,6,1,-1]
Explanation: 
- index 0 --> the greatest element to the right of index 0 is index 1 (18).
- index 1 --> the greatest element to the right of index 1 is index 4 (6).
- index 2 --> the greatest element to the right of index 2 is index 4 (6).
- index 3 --> the greatest element to the right of index 3 is index 4 (6).
- index 4 --> the greatest element to the right of index 4 is index 5 (1).
- index 5 --> there are no elements to the right of index 5, so we put -1.
```

#### **Example 2:**

```
Input: arr = [400]
Output: [-1]
Explanation: There are no elements to the right of index 0.
```

**Constraints:**

+ `1 <= arr.length <= 10⁴`
+ `1 <= arr[i] <= 10⁵`

## Solution

### Approach 1

#### Algorithm

The key insight is to think backwards. Instead of finding the maximum to the right of each element individually (which would be O(n²)), we can traverse the array from right to left and maintain the maximum seen so far.

Why right to left?

The rightmost element has no elements to its right → answer is -1
For every other element, we already know the maximum of all elements to its right from the previous iteration
We update the maximum as we move left
This is like a reverse scan where we build the answer while tracking the running maximum.

#### Implementation
My implementation.

#### Complexity Analysis

Time complexity: `O(n)`
Space complexity: `O(1)`

### Approach 2

#### Algorithm

The key insight is to think backwards. Instead of finding the maximum to the right of each element individually (which would be O(n²)), we can traverse the array from right to left and maintain the maximum seen so far.

Why right to left?

The rightmost element has no elements to its right → answer is -1
For every other element, we already know the maximum of all elements to its right from the previous iteration
We update the maximum as we move left
This is like a reverse scan where we build the answer while tracking the running maximum.

Approach is the same but tacking into account `n`th element only assigned to maximum value of a `n+1`th to `arr` length series.

#### Implementation
Current implementation.

#### Complexity Analysis

Time complexity: `O(n)`
Space complexity: `O(1)`