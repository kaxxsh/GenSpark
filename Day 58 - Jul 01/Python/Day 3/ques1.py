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
