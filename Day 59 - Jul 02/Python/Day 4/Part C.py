# https://leetcode.com/problems/longest-substring-without-repeating-characters/description/

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
    
# https://leetcode.com/problems/zigzag-conversion/submissions/1306613287/

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


# https://leetcode.com/problems/3sum-closest/submissions/1306600074/


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



# https://leetcode.com/problems/generate-parentheses/submissions/1306603609/


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


# https://leetcode.com/problems/multiply-strings/submissions/1306605917/

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


# https://leetcode.com/problems/group-anagrams/submissions/1306607998/

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
    

# https://leetcode.com/problems/multiply-strings/submissions/1306614093/


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


# https://leetcode.com/problems/jump-game/submissions/1306611140/


class Solution(object):
    def canJump(self, nums):
        length = len(nums)
        begin = length - 1
        for i in reversed(range(length - 1)):
            if i + nums[i] >= begin:
                begin = i
        return not begin
    

# https://leetcode.com/problems/unique-paths/submissions/1306611722/


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
    


# https://leetcode.com/problems/text-justification/submissions/1306617778/


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