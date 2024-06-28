import random

words = ["apple", "banana", "cherry", "date", "elderberry"]

target_word = random.choice(words)

attempts = 0

def calculate_cows_and_bulls(guess, target):
    bulls = sum(g == t for g, t in zip(guess, target))
    cows = sum(min(guess.count(c), target.count(c)) for c in set(guess)) - bulls
    return cows, bulls

print("Welcome to the Cows and Bulls Game!")
print("Guess the 5-letter word. For each guess, you'll get the number of Cows and Bulls.")
print("'Cow' means a correct letter in the wrong position, and 'Bull' means a correct letter in the correct position.")

while True:
    user_guess = input("Enter your guess: ").lower()
    attempts += 1
    
    if len(user_guess) != len(target_word):
        print(f"Please enter a {len(target_word)}-letter word.")
        continue
    
    if user_guess == target_word:
        print(f"Congratulations! You've guessed the word correctly in {attempts} attempts.")
        break
    
    cows, bulls = calculate_cows_and_bulls(user_guess, target_word)
    print(f"{bulls} Bulls, {cows} Cows")