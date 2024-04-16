# GenSpark Training Day 6 Apr 16

# Task

# Employee Management System

This is a console application implemented in C# using .NET 6. It's an Employee Management System that allows you to perform various operations related to employees.

## Features

The system provides the following options:

1. Add New Employee
2. View All Employees
3. Update Employee Details
4. Delete Employee
5. Calculate Gratuity Amount
6. Calculate Employee PF
7. View Leave Details
8. Exit

### Class ABC:

- Data Members: `empid`, `name`, `dept`, `desg`, and `basicSalary` are set through a parameterized constructor.
- Employee PF Calculation: 12% of the basic salary goes to the employee's PF. Additionally, 8.33% of the basic salary is contributed by the employer to the PF, with 3.67% of the employer contribution going to the Pension Fund.
- Leave Details: For employees in the ABC class:
    - 1 day of Casual Leave per month.
    - 12 days of Sick Leave per year.
    - 10 days of Privilege Leave per year.
- Gratuity Amount: The gratuity amount is calculated based on years of service:
    - If the employee has completed more than 5 years of service, 1 month of basic salary is deposited into the gratuity fund.
    - If more than 10 years of service have been completed, the gratuity amount is equal to 2 months' basic salary.
    - If more than 20 years of service have been completed, the gratuity amount is equal to 3 months' basic salary.
    - If less than 5 years of service have been completed, there is no gratuity amount.

### Class XYZ:

- Data Members: `empid`, `name`, `dept`, `desg`, and `basicSalary` are set through a parameterized constructor.
- Employee PF Calculation: 12% of the basic salary goes to the employee's PF. Additionally, 12% of the employer's contribution goes to the PF.
- Leave Details: For employees in the XYZ class:
    - 2 days of Casual Leave per month.
    - 5 days of Sick Leave per year.
    - 5 days of Privilege Leave per year.
- Gratuity Amount: Gratuity is not applicable for employees in the XYZ class.

## RESULT

1. Add Employee

![Add](https://github.com/kaxxsh/GenSpark/blob/main/Results/Day%206/AddData.png)

2. Edit Employee

![Edit](https://github.com/kaxxsh/GenSpark/blob/main/Results/Day%206/Edit.png)

3. Delete Employee

![Delete](https://github.com/kaxxsh/GenSpark/blob/main/Results/Day%206/Delete.png)

4. View Employee

![View](https://github.com/kaxxsh/GenSpark/blob/main/Results/Day%206/ViewData.png)

5. Policy

![Policy](https://github.com/kaxxsh/GenSpark/blob/main/Results/Day%206/Policy.png)

## Repository

The repository for this project can be found [here](https://github.com/gayat19/FSD09Apr2024).