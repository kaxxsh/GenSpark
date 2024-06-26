def is_prime(num):
    if num < 2:
        return False
    for i in range(2, int(num ** 0.5) + 1):
        if num % i == 0:
            return False
    return True

numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
prime_numbers = [num for num in numbers if is_prime(num)]
average = sum(prime_numbers) / len(prime_numbers)

print("Prime numbers:", prime_numbers)
print("Average of prime numbers:", average)