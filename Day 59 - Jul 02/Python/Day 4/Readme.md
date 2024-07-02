# Genspark Training

## PART A

## HackerRank Solution Certificate

### Python Basic

- **Certificate Link**: [click here](./Part%20A.pdf)

## PART B

## HackerRank Solutions

### Collections Counter

- **Problem**: [Collections Counter](https://www.hackerrank.com/challenges/collections-counter/problem?isFullScreen=true)
- **Solution**:

  ```python
  from collections import Counter

  def earned(sales, stock):
      earned = 0

      for i in range(sales):
          sale = input().split(" ")
          shoe, price = sale[0], int(sale[1])

          if shoe in stock and stock[shoe] >= 1:
              earned += price
              stock[shoe] -= 1
          else:
              continue

      return earned

  stock_len = int(input())
  stock = dict(Counter([i for i in input().split(" ")]))
  sales = int(input())

  print(earned(sales, stock))
  ```

### Most Common

- **Problem**: [Most Common](https://www.hackerrank.com/challenges/most-commons/problem?isFullScreen=true)
- **Solution**:

  ```python
  import math
  import os
  import random
  import re
  import sys

  if __name__ == '__main__':
      s = input()

      letters = {l:s.count(l) for l in s}
      print("\n".join([f"{l} {letters[l]}" for l in sorted(sorted(letters), key=lambda x: letters[x], reverse=True)[:3]]))
  ```

### Python If-Else

- **Problem**: [Python If-Else](https://www.hackerrank.com/challenges/py-if-else/problem?isFullScreen=true)
- **Solution**:

  ```python
  def odd(num):
      if num % 2 != 0:
          return "Weird"
      else:
          return even(num)

  def even(num):
      if 2 <= num <= 5:
          return "Not Weird"
      elif 6 <= num <= 20:


          return "Weird"
      elif num > 20:
          return "Not Weird"

  N = int(input())
  print(odd(N))
  ```

### Python Arithmetic Operators

- **Problem**: [Python Arithmetic Operators](https://www.hackerrank.com/challenges/python-arithmetic-operators/problem?isFullScreen=true)
- **Solution**:

  ```python
  if __name__ == '__main__':
      a = int(input())
      b = int(input())

      def add_two(x, y):
          return x + y

      def ext_two(x, y):
          return x - y

      def mul_two(x, y):
          return x * y

      print(add_two(a, b))
      print(ext_two(a, b))
      print(mul_two(a, b))
  ```

### Python Division

- **Problem**: [Python Division](https://www.hackerrank.com/challenges/python-division/problem?isFullScreen=true)
- **Solution**:

  ```python
  if __name__ == '__main__':
      a = int(input())
      b = int(input())

      def division_int(x, y):
          return x // y

      def division_flt(x, y):
          return x / y

      print(division_int(a, b))
      print(division_flt(a, b))
  ```

### Python Loops

- **Problem**: [Python Loops](https://www.hackerrank.com/challenges/python-loops/problem?isFullScreen=true)
- **Solution**:
  ```python
  if __name__ == '__main__':
      n = int(input())
      i = 0
      while i < n:
          r = i * i
          i = i + 1
          print(r)
  ```

### Write a Function

- **Problem**: [Write a Function](https://www.hackerrank.com/challenges/write-a-function/problem?isFullScreen=true)
- **Solution**:

  ```python
  def is_leap(year):
      leap = False

      if year % 4 == 0:
          if year % 100 == 0 :
              if year % 400 == 0:
                  leap = True
              else:
                  leap = False
          else:
              leap = True
      else :
          leap = False
      return leap

  year = int(input())
  print(is_leap(year))
  ```

### Python Print

- **Problem**: [Python Print](https://www.hackerrank.com/challenges/python-print/problem?isFullScreen=true)
- **Solution**:
  ```python
  if __name__ == '__main__':
      n = int(input())
      lst = []
      for num in range(1, n+1):
          lst.append(str(num))
      print("".join(lst))
  ```

### List Comprehensions

- **Problem**: [List Comprehensions](https://www.hackerrank.com/challenges/list-comprehensions/problem?isFullScreen=true)
- **Solution**:

  ```python
  if __name__ == '__main__':
      x = int(input())
      y = int(input())
      z = int(input())
      n = int(input())

      ar = []
      p = 0

      for i in range ( x + 1 ) :
          for j in range( y + 1):
              for k in range( z + 1):
                  if i+j+k != n:
                      ar.append([])
                      ar[p] = [ i , j, k ]
                      p+=1
      print(ar)
  ```

### Find Second Maximum Number in a List

- **Problem**: [Find Second Maximum Number in a List](https://www.hackerrank.com/challenges/find-second-maximum-number-in-a-list/problem?isFullScreen=true)
- **Solution**:

  ```python
  if __name__ == '__main__':
      n = int(input())
      arr = list(map(int, input().split()))
      mx = max(arr)
      sc = None

      for num in arr:
          if num == mx:
              pass
          elif sc == None:
              sc = num
          elif num > sc:
              sc = num

      print(sc)
  ```

### Nested Lists

- **Problem**: [Nested Lists](https://www.hackerrank.com/challenges/nested-list/problem?isFullScreen=true)
- **Solution**:
  ```python
  if __name__ == '__main__':
      students = []
      for _ in range(int(input())):
          name = input()
          score = float(input())
          students.append([name, score])
      mn = min(students, key=lambda x: x[1])
      nonlowest = sorted([student for student in students if student[1] > mn[1]], key= lambda x: x[1])
      seconds = sorted([student[0] for student in nonlowest if student[1] == nonlowest[0][1]])
      for student in seconds:
          print(student)
  ```

### Finding the Percentage

- **Problem**: [Finding the Percentage](https://www.hackerrank.com/challenges/finding-the-percentage/problem?isFullScreen=true)
- **Solution**:

  ```python
  from functools import reduce

  if __name__ == '__main__':
      n = int(input())
      student_marks = {}
      for _ in range(n):
          name, *line = input().split()
          scores = list(map(float, line))
          student_marks[name] = scores
      query_name = input()

      marks = student_marks[query_name]
      sum_marks = reduce(lambda x, y: x + y, marks, 0)
      avg_marks = sum_marks / len(marks)
      print("{:.2f}".format(avg_marks))
  ```

## PART C

## LeetCode Solutions

### Longest Substring Without Repeating Characters

- **Problem**: [Longest Substring Without Repeating Characters](https://leetcode.com/problems/longest-substring-without-repeating-characters/description/)
- **Solution**:
  ```python
  class Solution(object):
      def lengthOfLongestSubstring(self, s):
          charMap = {}
          for i in range(256):
              charMap[i] = -1
          ls = len(s)
          i = max_len = 0
          for j in range(ls):
              if charMap[ord(s[j])] >= i:
                  i = charMap[ord(s[j])] + 1
              charMap[ord(s[j])] = j
              max_len = max(max_len, j - i + 1)
          return max_len
  ```

### Zigzag Conversion

- **Problem**: [Zigzag Conversion](https://leetcode.com/problems/zigzag-conversion/submissions/1306613287/)
- **Solution**:

  ```python
  class Solution(object):
      def convert(self, s, numRows):
          if numRows == 1:
              return s
          p = 2 * (numRows - 1)
          result = [""] * numRows
          for i in range(len(s)):
              floor = i % p
              if floor >= p // 2:
                  floor = p - floor
              result[floor] += s[i]
          return "".join(result)

  if __name__ == '__main__':
      s = Solution()
      print(s.convert("PAYPALISHIRING", 3))
  ```

### 3Sum Closest

- **Problem**: [3Sum Closest](https://leetcode.com/problems/3sum-closest/submissions/1306600074/)
- **Solution**:
  ```python
  class Solution(object):
      def threeSumClosest(self, nums, target):
          ls = len(nums)
          sort_nums = sorted(nums)
          res = nums[0] + nums[1] + nums[2]
          for i in range(ls - 2):
              j, k = i + 1, ls - 1
              while j < k:
                  temp = sort_nums[i] + sort_nums[j] + sort_nums[k]
                  if abs(target - temp) < abs(target - res):
                      res = temp
                  if temp < target:
                      j += 1
                  else:
                      k -= 1
          return res
  ```

### Generate Parentheses

- **Problem**: [Generate Parentheses](https://leetcode.com/problems/generate-parentheses/submissions/1306603609/)
- **Solution**:
  ```python
  class Solution(object):
      def generateParenthesis(self, n):
          if n == 1:
              return ['()']
          last_list = self.generateParenthesis(n - 1)
          res = []
          for t in last_list:
              curr = t + ')'
              for index in range(len(curr)):
                  if curr[index] == ')':
                      res.append(curr[:index] + '(' + curr[index:])
          return list(set(res))
  ```

### Multiply Strings

- **Problem**: [Multiply Strings](https://leetcode.com/problems/multiply-strings/submissions/1306605917/)
- **Solution**:

  ```python
  class Solution(object):
      def multiply(self, num1, num2):
          if num1 == '0' or num2 == '0':
              return '0'

          ls1, ls2 = len(num1), len(num2)
          ls = ls1 + ls2
          arr = [0] * ls

          for i in reversed(range(ls1)):
              for j in reversed(range(ls2)):
                  arr[i + j + 1] += int(num1[i]) * int(num2[j])

          for i in reversed(range(1, ls)):
              arr[i - 1] += arr[i] // 10
              arr[i] %= 10

          pos = 0
          if arr[pos] == 0:
              pos += 1

          res = ''
          while pos < ls:
              res += str(arr[pos])
              pos += 1

          return res

  if __name__ == '__main__':
      s = Solution()
      print(s.multiply("98", "9"))
  ```

### Group Anagrams

- **Problem**: [Group Anagrams](https://leetcode.com/problems/group-anagrams/submissions/1306607998/)
- **Solution**:

  ```python
  class Solution(object):
      def groupAnagrams(self, strs):
          strs.sort()
          hash = {}
          for s in strs:
              key = self.hash_key(s)
              try:
                  hash[key].append(s)
              except KeyError:
                  hash[key] = [s]
          return hash.values()

      def hash_key(self, s):
          table = [0] * 26
          for ch in s:
              index = ord(ch) - ord('a')
              table[index] += 1
          return str(table)
  ```

### Jump Game

- **Problem**: [Jump Game](https://leetcode.com/problems/jump-game/submissions/1306611140/)
- **Solution**:
  ```python
  class Solution(object):
      def canJump(self, nums):
          length = len(nums)
          begin = length - 1
          for i in reversed(range(length - 1)):
              if i + nums[i] >= begin:
                  begin = i
          return not begin
  ```

### Unique Paths

- **Problem**: [Unique Paths](https://leetcode.com/problems/unique-paths/submissions/1306611722/)
- **Solution**:
  ```python
  class Solution:
      def uniquePaths(self, m, n):
          dmap = [[0] * n for _ in range(m)]
          for i in range(m):
              dmap[i][0] = 1
          for j in range(n):
              dmap[0][j] = 1
          for i in range(1, m):
              for j in range(1, n):
                  l = u = 0
                  if i-1 >= 0:
                      u = dmap[i-1][j]
                  if j-1>= 0:
                      l = dmap[i][j-1]
                  dmap[i][j] = l + u
          return dmap[m-1][n-1]
  ```

### Text Justification

- **Problem**: [Text Justification](https://leetcode.com/problems/text-justification/submissions/1306617778/)
- **Solution**:

  ```python
  class Solution:
    def fullJustify(self, words: List[str], maxWidth: int) -> List[str]:
      ans = []
      row = []
      rowLetters = 0

      for word in words:
        if rowLetters + len(word) + len(row) > maxWidth:
          for i in range(maxWidth - rowLetters):
            row[i % (len(row) - 1 or 1)] += ' '
          ans.append(''.join(row))
          row = []
          rowLetters = 0
        row.append(word)
        rowLetters += len(word)

      return ans + [' '.join(row).ljust(maxWidth)]
  ```
