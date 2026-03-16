# 217. Contains Duplicate

### Desctription

Given an integer array `nums`, return true if any value appears at least twice in `the` array, and return `false` if every element is distinct.

### Example

#### **Example 1:**

```
Input: nums = [1,2,3,1]
Output: true
Explanation:
The element 1 occurs at the indices 0 and 3.
```
#### **Example 2:**
```
Input: nums = [1,2,3,4]
Output: false
Explanation:
All elements are distinct.
```
#### **Example 3:**

```
Input: nums = [1,1,1,3,3,4,3,2,4,2]
Output: true
```

**Constraints:**

+ `1 <= nums.length <= 10⁵`
+ `-10⁹ <= nums[i] <= 10⁹`

## Solution

### Approach 1: Sorting

#### Algorithm
The sorting approach sorts the array in ascending order and then checks for adjacent elements that are the same. If any duplicates are found, it returns `true`. Sorting helps in bringing duplicates together, simplifying the check. However, sorting has a time complexity of $O(n *log n)$.

#### Implementation
My implementation.

#### Complexity Analysis

+ Time complexity: $O(n log n)$.
For each element, we try to find its complement by looping through the rest of the array which takes $O(n)$ time. Therefore, the time complexity is $O(n^2)$.

+ Space complexity: $O(1)$.
The space required does not depend on the size of the input array, so only constant space is used.

### Approach 2: Hash Table

#### Algorithm
I'm using a set to track seen numbers as I iterate:

Create an empty set called 'check' to store numbers we've encountered
Loop through each number in the input array
For each number, check if it's already in our set:
If not in the set, add it and continue
If already in the set, we found a duplicate so return True immediately
If we finish the loop without finding duplicates, return False
The early return when finding a duplicate makes this efficient - we don't need to check the entire array if we find a match early on.

#### Implementation

Present uncommented.

#### Complexity Analysis

+ Time complexity: $O(n)$
where $n$ is the length of the array. We potentially traverse the entire array once, and set operations (add and membership check) are $O(1)$ on average.

+ Space complexity: $O(n)$
where $n$ is the length of the array. In the worst case (no duplicates), we store all n elements in the set.