# 1929. Concatenation of Array

### Desctription

Given an integer array `nums` of length `n`, you want to create an array `ans` of length `2n` where `ans[i] == nums[i]` and `ans[i + n] == nums[i]` for `0 <= i < n` (0-indexed).

Specifically, `ans` is the concatenation of two `nums` arrays.

Return *the array* `ans`.

### Example

#### **Example 1:**

```
Input: nums = [1,2,1]
Output: [1,2,1,1,2,1]
Explanation: The array ans is formed as follows:
- ans = [nums[0],nums[1],nums[2],nums[0],nums[1],nums[2]]
- ans = [1,2,1,1,2,1]
```

#### **Example 2:**

```
Input: nums = [1,3,2,1]
Output: [1,3,2,1,1,3,2,1]
Explanation: The array ans is formed as follows:
- ans = [nums[0],nums[1],nums[2],nums[3],nums[0],nums[1],nums[2],nums[3]]
- ans = [1,3,2,1,1,3,2,1]
```

**Constraints:**

+ `n == nums.length`
+ `1 <= n <= 1000`
+ `1 <= nums[i] <= 1000`

## Solution

### Approach 1: Brute force

#### Algorithm


#### Implementation
My implementation.

#### Complexity Analysis

+ Time complexity: $O(n^2)$.
For each element, we try to find its complement by looping through the rest of the array which takes $O(n)$ time. Therefore, the time complexity is $O(n^2)$.

+ Space complexity: $O(1)$.
The space required does not depend on the size of the input array, so only constant space is used.

### Approach 3: One-pass Hash Table

#### Algorithm

1. Create a new integer array 'ans' of size '2*len', where 'len' is the length of the input array 'nums'.
2. Iterate over the elements of 'nums' using a for loop.
3. For each element at index 'i', assign 'nums[i]' to 'ans[i]' (copy the element).
4. Assign 'nums[i]' to 'ans[i+len]' (append the element to the end of the array).
5. Return the resulting array 'ans'.

#### Implementation

My solution

#### Complexity Analysis

Time complexity: `O(n)`
Space complexity: `O(2n)`