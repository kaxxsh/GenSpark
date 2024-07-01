# 1. Python Class

class Dog:
    def __init__(self, name, age):
        self.name = name
        self.age = age

    def bark(self):
        return f"{self.name} says Woof!"
    
    def get_age(self):
        return self.age

# Create an instance of the Dog class
my_dog = Dog("Buddy", 3)
print(my_dog.bark())
print(my_dog.get_age())


# 2. Inheritance

class Animal:
    def __init__(self, name):
        self.name = name

    def speak(self):
        raise NotImplementedError("Subclass must implement abstract method")

class Dog(Animal):
    def speak(self):
        return f"{self.name} says Woof!"

class Cat(Animal):
    def speak(self):
        return f"{self.name} says Meow!"

# Instances
dog = Dog("Buddy")
cat = Cat("Whiskers")

print(dog.speak())
print(cat.speak())


# 3. Polymorphism

class Bird:
    def sound(self):
        return "Tweet"

class Fish:
    def sound(self):
        return "Blub"

# Function demonstrating polymorphism
def make_sound(animal):
    print(animal.sound())

# Instances
bird = Bird()
fish = Fish()

make_sound(bird)
make_sound(fish)


# 4. Modules

# my_module.py
def greet(name):
    return f"Hello, {name}!"

# main.py
import my_module

print(my_module.greet("Alice"))


# 5. Exception Handling 

try:
    result = 10 / 0
except ZeroDivisionError:
    print("You can't divide by zero!")
finally:
    print("This will run no matter what.")


# 6. File Handling

# Writing to a file
with open('path.txt', 'w') as file:
    file.write("Hello, world!")

# Reading from a file
with open('path.txt', 'r') as file:
    content = file.read()
    print(content)
