# Genspark Training Python Day 3

## Description

This Python application collects employee details (Name, Date of Birth, Phone, and E-Mail) from the console, validates the input, calculates the employee's age, and provides options to save the data in text, Excel, or PDF format. Additionally, there is an optional feature to bulk read employee details from an Excel file and store them in a list.

## Features

1. Collects employee details from the console.
2. Validates the input data.
3. Calculates the age of the employee (based on Date of Birth).
4. Provides options to save the data in text, Excel, or PDF format.
5. Optionally reads bulk data from an Excel file and stores it in a list.

## Prerequisites

- Python 3.x
- Required Python libraries:
  - `pandas`
  - `openpyxl`
  - `reportlab`

Install the required libraries using:

```sh
pip install pandas openpyxl reportlab
```

## Usage

### 1. Running the Application

Run the main application script:

```sh
python employee_app.py
```

### 2. Input Format

- **Name**: String (e.g., John Doe)
- **Date of Birth**: String in `YYYY-MM-DD` format (e.g., 1990-01-01)
- **Phone**: String of 10 digits (e.g., 1234567890)
- **E-Mail**: Valid email address (e.g., johndoe@example.com)

### 3. Menu Options

After entering the employee details, the application will display a menu to choose the file format for saving the data:

1. Save as Text File
2. Save as Excel File
3. Save as PDF File

Choose an option by entering the corresponding number.

### 4. Bulk Read from Excel (Optional)

To enable the bulk read feature, ensure you have an Excel file named `employees.xlsx` with the following columns:

- `Name`
- `DOB`
- `Phone`
- `Email`

Run the script with the bulk read option:

```sh
python employee_app.py --bulk-read
```

## Example

### Input

```sh
Enter Name: John Doe
Enter Date of Birth (YYYY-MM-DD): 1990-01-01
Enter Phone: 1234567890
Enter E-Mail: johndoe@example.com
```

### Menu

```sh
Choose a file format to save the data:
1. Save as Text File
2. Save as Excel File
3. Save as PDF File
Enter your choice: 1
```

## Code Overview

```python
import datetime
import pandas as pd
from fpdf import FPDF

class Employee:
    def __init__(self, name, dob, phone, email):
        self.name = name
        self.dob = dob
        self.phone = phone
        self.email = email

    def calculate_age(self):
        dob_date = datetime.datetime.strptime(self.dob, '%Y-%m-%d')
        today = datetime.datetime.now()
        return today.year - dob_date.year - ((today.month, today.day) < (dob_date.month, dob_date.day))

def input_employee_details():
    name = input("Enter Name: ")
    dob = input("Enter DOB (YYYY-MM-DD): ")
    phone = input("Enter Phone: ")
    email = input("Enter Email: ")
    employee = Employee(name, dob, phone, email)
    return employee

def save_to_text(employees):
    with open("employee_details.txt", "w") as file:
        for employee in employees:
            file.write(f"Name: {employee.name}, DOB: {employee.dob}, Phone: {employee.phone}, Email: {employee.email}, Age: {employee.calculate_age()}\n")

def save_to_excel(employees):
    data = [[employee.name, employee.dob, employee.phone, employee.email, employee.calculate_age()] for employee in employees]
    df = pd.DataFrame(data, columns=["Name", "DOB", "Phone", "Email", "Age"])
    df.to_excel("employee_details.xlsx", index=False)

def save_to_pdf(employees):
    pdf = FPDF()
    pdf.add_page()
    pdf.set_font("Arial", size=12)
    for employee in employees:
        pdf.cell(200, 10, txt=f"Name: {employee.name}, DOB: {employee.dob}, Phone: {employee.phone}, Email: {employee.email}, Age: {employee.calculate_age()}", ln=True)
    pdf.output("employee_details.pdf")

def read_employees_from_excel(file_path):
    df = pd.read_excel(file_path)
    employees = []
    for index, row in df.iterrows():
        employee = Employee(row["Name"], row["DOB"], row["Phone"], row["Email"])
        employees.append(employee)
    return employees

def main():
    print("Choose an option:")
    print("1. Input Employee Details\n2. Bulk Read from Excel")
    option = input("Enter your option: ")

    if option == "1":
        employee = input_employee_details()
        employees = [employee]
    elif option == "2":
        file_path = input("Enter the path to the Excel file: ")
        employees = read_employees_from_excel(file_path)
    else:
        print("Invalid option")
        return

    print("Choose the format to save:")
    print("1. Text\n2. Excel\n3. PDF")
    choice = input("Enter your choice: ")
    if choice == "1":
        save_to_text(employees)
    elif choice == "2":
        save_to_excel(employees)
    elif choice == "3":
        save_to_pdf(employees)
    else:
        print("Invalid choice")

if __name__ == "__main__":
    main()

```

