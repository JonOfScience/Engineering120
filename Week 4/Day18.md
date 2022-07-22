# Day 18 - 20/07/2022 - 

[TOC]

## Stand-up

Stick to what the requirements are and make tests from those (**Don't make assumptions**)

## Big O Notation

*"The efficiency of your algorithm" - Nish*

Different kinds of complexity
- Time complexity -> Big O Notion (related to theoretical running time of your algorithm)
- Space (memory) complexity

Best case, worst case, average case

Algorithm - A set of instructions

### A "Good" Algorithm
- Correctness (produces expected answer for allowed inputs)
- Efficiency (time and space)

How do we measure time efficiency?
- Count the operations *T(n)*
- Use big-*O* notation

| Type | Notation |
|-|-|
| Constant Running Time                             | $O(1)$ |
| Linear - Traversing a list                        | $O(n)$ |
| Quadratic - Two nested loops - Traditional sorts  | $O(n^2)$ |
| Cubic - Three nested loops                        | $O(n^3)$ |
| Logarithmic - number of layers in binary tree     | $O(log_2 (n))$ |
| Optimal sorts                                     | $O(nlog_2 (n))$ |
| Factorial (unreasonable)                          | $O(n!)$ |
| Power (*deeply* unreasonable)                     | $O(2^n)$ or $O(n^n)$ |

if we have *O(30n)* is regarded as *O(n)* as **constants don't matter**.

#### Log notation examples
**Example 1**
2^3 = 8
log_2(8) = 3

**Example 2**
10^2 = 100
log_10(100) = 2

| Array Size | $O(n^2)$ | $O(log_2(n))$ | 
| - | - | - |
| 2 | 4 | 1 |
| 4 | 16 | 2 |
| 8 | 256 | 3 |

## Recursion

Repeat until base case is reached
without base case we will get infinite recursion (stack overflow)

SUM BY RECURSION - ALGORITHM FLOW AND CALL STACK

FACTORIAL BY RECURSION

Iterative approaches don't have much overhead - Little chance of stack overflow
Recursive approaches use more memory but can be more efficient
