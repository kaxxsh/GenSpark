-- Create Department table
CREATE TABLE Department (
    department_id SERIAL PRIMARY KEY,
    department_name VARCHAR(50) NOT NULL
);

-- Create Employee table
CREATE TABLE Employee (
    employee_id SERIAL PRIMARY KEY,
    employee_name VARCHAR(50) NOT NULL,
    age INT,
    phone VARCHAR(15),
    department_id INT,
    FOREIGN KEY (department_id) REFERENCES Department(department_id)
);

-- Create Salary table
CREATE TABLE Salary (
    salary_id SERIAL PRIMARY KEY,
    employee_id INT,
    salary DECIMAL(10, 2),
    FOREIGN KEY (employee_id) REFERENCES Employee(employee_id)
);

-- Insert data into Department table
INSERT INTO Department (department_name) VALUES
('HR'), ('Finance'), ('IT');

-- Insert data into Employee table
INSERT INTO Employee (employee_name, age, phone, department_id) VALUES
('kamesh', 30, '1234567890', 1),
('mukesh', 25, '2345678901', 2),
('jv', 35, '3456789012', 3);

-- Insert data into Salary table
INSERT INTO Salary (employee_id, salary) VALUES
(1, 50000.00),
(2, 60000.00),
(3, 70000.00);
