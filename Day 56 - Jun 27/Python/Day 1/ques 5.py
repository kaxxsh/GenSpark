import re

def validate_name(name):
    if re.match(r'^[A-Za-z\s]+$', name):
        return True
    return False

def validate_age(age):
    if age.isdigit() and int(age) > 0:
        return True
    return False

def validate_date_of_birth(date_of_birth):
    if re.match(r'^\d{2}/\d{2}/\d{4}$', date_of_birth):
        return True
    return False

def validate_phone(phone):
    if re.match(r'^\d{10}$', phone):
        return True
    return False

def print_details(name, age, date_of_birth, phone):
    print("Name:", name)
    print("Age:", age)
    print("Date of Birth:", date_of_birth)
    print("Phone:", phone)

name = input("Enter your name: ")
age = input("Enter your age: ")
date_of_birth = input("Enter your date of birth (DD/MM/YYYY): ")
phone = input("Enter your phone number: ")

if validate_name(name) and validate_age(age) and validate_date_of_birth(date_of_birth) and validate_phone(phone):
    print_details(name, age, date_of_birth, phone)
else:
    print("Invalid input. Please enter valid details.")