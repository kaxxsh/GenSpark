# https://www.hackerrank.com/challenges/python-lists/problem?isFullScreen=true

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


# https://www.hackerrank.com/challenges/python-tuples/problem?isFullScreen=true

if __name__ == '__main__':
    n = int(input())
    integer_list = map(int, input().split())
    print(hash(tuple(integer_list)))


# https://www.hackerrank.com/challenges/swap-case/problem?isFullScreen=true

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


# https://www.hackerrank.com/challenges/python-string-split-and-join/problem?isFullScreen=true

def split_and_join(line):
    return "-".join(line.split())

if __name__ == '__main__':
    line = input()
    result = split_and_join(line)
    print(result)


# https://www.hackerrank.com/challenges/whats-your-name/problem?isFullScreen=true

def print_full_name(a, b):
    print(f"Hello {a} {b}! You just delved into python.")

if __name__ == '__main__':
    first_name = input()
    last_name = input()
    print_full_name(first_name, last_name)


# https://www.hackerrank.com/challenges/python-mutations?isFullScreen=true

def mutate_string(string, position, character):
    return "".join([character if e == position else c for e,c in enumerate(string)])

if __name__ == '__main__':
    s = input()
    i, c = input().split()
    s_new = mutate_string(s, int(i), c)
    print(s_new)


# https://www.hackerrank.com/challenges/find-a-string/problem?isFullScreen=true


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


# https://www.hackerrank.com/challenges/string-validators/problem?isFullScreen=true

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


# https://www.hackerrank.com/challenges/text-alignment/problem?isFullScreen=true

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

# https://www.hackerrank.com/challenges/text-wrap/problem?isFullScreen=true

import textwrap

def wrap(string, max_width):
    return "\n".join([string[i:i+max_width] for i in range(0, len(string), max_width)])

if __name__ == '__main__':
    string, max_width = input(), int(input())
    result = wrap(string, max_width)
    print(result)
