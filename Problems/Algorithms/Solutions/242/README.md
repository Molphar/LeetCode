# 242. Valid Anagram

### Desctription

Given two strings `s` and `t`, return `true` if `t` is an anagram of `s`, and `false` otherwise.

### Example

#### **Example 1:**

```
Input: s = "anagram", t = "nagaram"

Output: true
```

#### **Example 2:**

```
Input: s = "rat", t = "car"

Output: false
```

**Constraints:**

+ `1 <= s.length, t.length <= 5 * 10⁴`
+ `s` and `t` consist of lowercase English letters.

## Solution

### Approach 1: Sorting and add to hashmap

#### Algorithm

Sorting both strings ensures that if they contain the same characters, they will result in the exact same sequence. By attempting to add the second sorted string to a hashmap that already contains the first, you are using the map's uniqueness constraint to do the comparison for you. A "failed" insertion is the signal that the strings are anagrams.
 
#### Implementation
My implementation.

#### Complexity Analysis

Time complexity: $O(2n log n + )$.

Space complexity: $O(4n)$.

### Approach 2: One-pass Hash Table

#### Algorithm

We use an integer array of fixed size (26 letters) to keep track of how many times each character appears.
For each position i in the strings:

We increment the counter for the character in s[i].
We decrement the counter for the character in t[i].
If the two strings are anagrams, after processing both, all counts must return to zero.
This approach avoids sorting and compares character frequencies directly in a single linear pass.

#### Implementation

Present uncommented.

#### Complexity Analysis

Time complexity: $O(n)$.
We traverse both strings once, and checking the array at the end takes constant time (26 iterations).

Space complexity: $O(1)$.
 We use a fixed-size array (constant space, independent of input size).