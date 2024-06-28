def lengthOfLongestSubstring(s):
    charIndexMap = {}
    maxLength = 0
    start = 0
    
    for end in range(len(s)):
        if s[end] in charIndexMap:
            start = max(start, charIndexMap[s[end]] + 1)
        charIndexMap[s[end]] = end
        maxLength = max(maxLength, end - start + 1)
    
    return maxLength

user_input = input("Please enter something: ")
print("You entered:", user_input)