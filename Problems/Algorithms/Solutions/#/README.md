# 

### Desctription



### Example

#### **Example 1:**

```

```

**Constraints:**

+ `2 <= nums.length <= 10⁴`
+ `-10⁹ <= nums[i] <= 10⁹`
+ `-10⁹ <= target <= 10⁹`
+ `Only one valid answer exists.`
+ ` ⁰ ¹ ² ³ ⁴ ⁵ ⁶ ⁷ ⁸ ⁹`

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

It turns out we can do it in one-pass. While we are iterating and inserting elements into the hash table, we also look back to check if current element's complement already exists in the hash table. If it exists, we have found a solution and return the indices immediately.

#### Implementation

Present uncommented.

#### Complexity Analysis

Time complexity: $O(n)$.
We traverse the list containing `n` elements only once. Each lookup in the table costs only $O(1)$ time.

Space complexity: $O(n)$.
The extra space required depends on the number of items stored in the hash table, which stores at most `n` elements.