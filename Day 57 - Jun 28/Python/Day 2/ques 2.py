def is_prime(n):
    if n <= 1:
        return False
    for i in range(2, int(n**0.5) + 1):
        if n % i == 0:
            return False
    return True

def print_primes_up_to(n):
    for i in range(2, n + 1):
        if is_prime(i):
            print(i, end=' ')

n = int(input("Enter a number: "))
print_primes_up_to(n)