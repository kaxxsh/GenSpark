# https://www.hackerrank.com/challenges/collections-counter/problem?isFullScreen=true

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

# https://www.hackerrank.com/challenges/most-commons/problem?isFullScreen=true

import math
import os
import random
import re
import sys



if __name__ == '__main__':
    s = input()

    letters = {l:s.count(l) for l in s}
    print("\n".join([f"{l} {letters[l]}" for l in sorted(sorted(letters), key=lambda x: letters[x], reverse=True)[:3]]))



# https://www.hackerrank.com/challenges/py-if-else/problem?isFullScreen=true

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


# https://www.hackerrank.com/challenges/python-arithmetic-operators/problem?isFullScreen=true

if __name__ == '__main__':
    a = int(input())
    b = int(input())

    def add_two(x,y):
        return x + y

    def ext_two(x,y):
        return x - y

    def mul_two(x,y):
        return x * y

    print(add_two(a,b))
    print(ext_two(a,b))
    print(mul_two(a,b))


# https://www.hackerrank.com/challenges/python-division/problem?isFullScreen=true

if __name__ == '__main__':
    a = int(input())
    b = int(input())

    def division_int(x,y):
        return x // y

    def division_flt(x,y):
        return x / y

    print(division_int(a,b))
    print(division_flt(a,b))


# https://www.hackerrank.com/challenges/python-loops/problem?isFullScreen=true

if __name__ == '__main__':
    n = int(input())
    i = 0
    while i < n:
        r = i * i
        i = i + 1
        print(r)


# https://www.hackerrank.com/challenges/write-a-function/problem?isFullScreen=true


def is_leap(year):
    leap = False

    # Write your logic here
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


# https://www.hackerrank.com/challenges/python-print/problem?isFullScreen=true

if __name__ == '__main__':
    n = int(input())
    lst = []
    for num in range(1, n+1):
      lst.append(str(num))
    print("".join(lst))


# https://www.hackerrank.com/challenges/list-comprehensions/problem?isFullScreen=true


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


# https://www.hackerrank.com/challenges/find-second-maximum-number-in-a-list/problem?isFullScreen=true

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


# https://www.hackerrank.com/challenges/nested-list/problem?isFullScreen=true

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


# https://www.hackerrank.com/challenges/finding-the-percentage/problem?isFullScreen=true


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
    avg_marks = sum_marks/len(marks)
    print("{:.2f}".format(avg_marks))


