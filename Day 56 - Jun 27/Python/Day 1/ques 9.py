def permute(string, left, right):
    if left == right:
        print(''.join(string))
    else:
        for i in range(left, right + 1):
            string[left], string[i] = string[i], string[left]
            permute(string, left + 1, right)
            string[left], string[i] = string[i], string[left] 

def find_permutations(string):
    n = len(string)
    if n == 0:
        print("String is empty.")
    else:
        string = list(string)
        permute(string, 0, n - 1)


find_permutations("abc")