# HackerRank Python Challenges Solutions

This repository contains solutions to various Python challenges from HackerRank. Each script is designed to solve a specific problem by implementing the required functionalities using Python.

## Challenges and Solutions

### 1. Python Lists
**Challenge Link**: [Python Lists](https://www.hackerrank.com/challenges/python-lists/problem?isFullScreen=true)

**Description**: This challenge involves performing various list operations based on input commands.

```python
if __name__ == '__main__':
    N = int(input())
    the_list = list()

    for _ in range(N):
        query = input().split()
        if query[0] == "print":
            print(the_list)
        elif query[0] == "insert":
            the_list.insert(int(query[1]), int(query[2]))
        elif query[0] == "remove":
            the_list.remove(int(query[1]))
        elif query[0] == "append":
            the_list.append(int(query[1]))
        elif query[0] == "sort":
            the_list = sorted(the_list)
        elif query[0] == "pop":
            the_list.pop()
        elif query[0] == "reverse":
            the_list.reverse()
```

### 2. Python Tuples
**Challenge Link**: [Python Tuples](https://www.hackerrank.com/challenges/python-tuples/problem?isFullScreen=true)

**Description**: This challenge requires creating a tuple from an input list and printing its hash value.

```python
if __name__ == '__main__':
    n = int(input())
    integer_list = map(int, input().split())
    print(hash(tuple(integer_list)))
```

### 3. Swap Case
**Challenge Link**: [Swap Case](https://www.hackerrank.com/challenges/swap-case/problem?isFullScreen=true)

**Description**: This challenge involves swapping the case of each character in a given string.

```python
def swap_case(s):
    swapped = ""

    for c in s:
        if c.islower():
            swapped = swapped + c.upper()
        elif c.isupper():
            swapped = swapped + c.lower()
        else:
            swapped = swapped + c

    return swapped

if __name__ == '__main__':
    s = input()
    result = swap_case(s)
    print(result)
```

### 4. String Split and Join
**Challenge Link**: [String Split and Join](https://www.hackerrank.com/challenges/python-string-split-and-join/problem?isFullScreen=true)

**Description**: This challenge requires splitting a string on spaces and joining the words with hyphens.

```python
def split_and_join(line):
    return "-".join(line.split())

if __name__ == '__main__':
    line = input()
    result = split_and_join(line)
    print(result)
```

### 5. What's Your Name?
**Challenge Link**: [What's Your Name?](https://www.hackerrank.com/challenges/whats-your-name/problem?isFullScreen=true)

**Description**: This challenge involves printing a formatted string with given first and last names.

```python
def print_full_name(a, b):
    print(f"Hello {a} {b}! You just delved into python.")

if __name__ == '__main__':
    first_name = input()
    last_name = input()
    print_full_name(first_name, last_name)
```

### 6. Mutations
**Challenge Link**: [Mutations](https://www.hackerrank.com/challenges/python-mutations?isFullScreen=true)

**Description**: This challenge involves modifying a string at a specified index with a given character.

```python
def mutate_string(string, position, character):
    return "".join([character if e == position else c for e,c in enumerate(string)])

if __name__ == '__main__':
    s = input()
    i, c = input().split()
    s_new = mutate_string(s, int(i), c)
    print(s_new)
```

### 7. Find a String
**Challenge Link**: [Find a String](https://www.hackerrank.com/challenges/find-a-string/problem?isFullScreen=true)

**Description**: This challenge requires counting the number of times a substring appears in a string.

```python
def count_substring(string, sub_string):
    counter = 0
    for i,c in enumerate(string):
        if i + len(sub_string) > len(string):
            break
        if string[i:i+len(sub_string)] == sub_string:
            counter += 1
    return counter

if __name__ == '__main__':
    string = input().strip()
    sub_string = input().strip()
    
    count = count_substring(string, sub_string)
    print(count)
```

### 8. String Validators
**Challenge Link**: [String Validators](https://www.hackerrank.com/challenges/string-validators/problem?isFullScreen=true)

**Description**: This challenge involves checking various string properties and printing the results.

```python
if __name__ == '__main__':
    def validator(s):
        alnum, alpha, digits, lower, upper = False, False, False, False, False

        for c in s:
            if c.isalnum():
                alnum = True
            if c.isalpha():
                alpha = True
            if c.isdigit():
                digits = True
            if c.islower():
                lower = True
            if c.isupper():
                upper = True

        print(alnum)
        print(alpha)
        print(digits)
        print(lower)
        print(upper)


    s = input()
    validator(s)
```

### 9. Text Alignment
**Challenge Link**: [Text Alignment](https://www.hackerrank.com/challenges/text-alignment/problem?isFullScreen=true)

**Description**: This challenge involves printing a specific pattern using text alignment techniques.

```python
thickness = int(input()) 
c = 'H'

for i in range(thickness):
    print((c * i).rjust(thickness - 1) + c + (c * i).ljust(thickness - 1))

for i in range(thickness + 1):
    print((c * thickness).center(thickness * 2) + (c * thickness).center(thickness * 6))

for i in range((thickness + 1) // 2):
    print((c * thickness * 5).center(thickness * 6))    


for i in range(thickness + 1):
    print((c * thickness).center(thickness * 2) + (c * thickness).center(thickness * 6))    

for i in range(thickness):
    print(((c * (thickness - i - 1)).rjust(thickness) + c + (c * (thickness - i - 1)).ljust(thickness)).rjust(thickness * 6))
```

### 10. Text Wrap
**Challenge Link**: [Text Wrap](https://www.hackerrank.com/challenges/text-wrap/problem?isFullScreen=true)

**Description**: This challenge requires wrapping a string into a paragraph of given width.

```python
import textwrap

def wrap(string, max_width):
    return "\n".join([string[i:i+max_width] for i in range(0, len(string), max_width)])

if __name__ == '__main__':
    string, max_width = input(), int(input())
    result = wrap(string, max_width)
    print(result)
```

