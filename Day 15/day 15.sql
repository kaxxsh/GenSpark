create database Task;

use task;

CREATE TABLE Employee (
    emp_id INT PRIMARY KEY,
    emp_name VARCHAR(100),
    salary DECIMAL(10, 2),
    boss_id INT,
    department_name VARCHAR(100),
    CONSTRAINT fk_employee_boss_id FOREIGN KEY (boss_id) REFERENCES Employee(emp_id)
);

CREATE TABLE Department (
    department_name VARCHAR(100) PRIMARY KEY,
    floor INT,
    phone VARCHAR(20),
    emp_id INT,
    CONSTRAINT fk_department_emp_id FOREIGN KEY (emp_id) REFERENCES Employee(emp_id)
);

CREATE TABLE Item (
    item_name VARCHAR(100) PRIMARY KEY,
    item_type VARCHAR(100),
    item_color VARCHAR(100)
);

CREATE TABLE Sales (
    sales_id INT PRIMARY KEY,
    sale_qty INT,
    department_name VARCHAR(100),
    item_name VARCHAR(100),
    CONSTRAINT fk_sales_department_name FOREIGN KEY (department_name) REFERENCES Department(department_name),
    CONSTRAINT fk_sales_item_name FOREIGN KEY (item_name) REFERENCES Item(item_name)
);

INSERT INTO Item (item_name, item_type, item_color)
VALUES
    ('Pocket Knife-Nile', 'E', 'Brown'),
    ('Pocket Knife-Avon', 'E', 'Brown'),
    ('Compass', 'N', NULL),
    ('Geo positioning system', 'N', NULL),
    ('Elephant Polo stick', 'R', 'Bamboo'),
    ('Camel Saddle', 'R', 'Brown'),
    ('Sextant', 'N', NULL),
    ('Map Measure', 'N', NULL),
    ('Boots-snake proof', 'C', 'Green'),
    ('Pith Helmet', 'C', 'Khaki'),
    ('Hat-polar Explorer', 'C', 'White'),
    ('Exploring in 10 Easy Lessons', 'B', NULL),
    ('Hammock', 'F', 'Khaki'),
    ('How to win Foreign Friends', 'B', NULL),
    ('Map case', 'E', 'Brown'),
    ('Safari Chair', 'F', 'Khaki'),
    ('Safari cooking kit', 'F', 'Khaki'),
    ('Stetson', 'C', 'Black'),
    ('Tent - 2 person', 'F', 'Khaki'),
    ('Tent -8 person', 'F', 'Khaki');

INSERT INTO Employee (emp_id, emp_name, salary, boss_id, department_name)
VALUES
    (1, 'Alice', 75000, NULL, 'Management'),
    (2, 'Ned', 45000, 1, 'Marketing'),
    (3, 'Andrew', 25000, 2, 'Marketing'),
    (4, 'Clare', 22000, 2, 'Marketing'),
    (5, 'Todd', 38000, 1, 'Accounting'),
    (6, 'Nancy', 22000, 5, 'Accounting'),
    (7, 'Brier', 43000, 1, 'Purchasing'),
    (8, 'Sarah', 56000, 7, 'Purchasing'),
    (9, 'Sophile', 35000, 1, 'Personnel'),
    (10, 'Sanjay', 15000, 3, 'Navigation'),
    (11, 'Rita', 15000, 4, 'Books'),
    (12, 'Gigi', 16000, 4, 'Clothes'),
    (13, 'Maggie', 11000, 4, 'Clothes'),
    (14, 'Paul', 15000, 3, 'Equipment'),
    (15, 'James', 15000, 3, 'Equipment'),
    (16, 'Pat', 15000, 3, 'Furniture'),
    (17, 'Mark', 15000, 3, 'Recreation');

INSERT INTO Department (department_name, floor, phone, emp_id)
VALUES
    ('Management', 5, '34', 1),
    ('Books', 1, '81', 4),
    ('Clothes', 2, '24', 4),
    ('Equipment', 3, '57', 3),
    ('Furniture', 4, '14', 3),
    ('Navigation', 1, '41', 3),
    ('Recreation', 2, '29', 4),
    ('Accounting', 5, '35', 5),
    ('Purchasing', 5, '36', 7),
    ('Personnel', 5, '37', 9),
    ('Marketing', 5, '38', 2);

INSERT INTO Sales (sales_id, sale_qty, department_name, item_name)
VALUES
    (101, 2, 'Clothes', 'Boots-snake proof'),
    (102, 1, 'Clothes', 'Pith Helmet'),
    (103, 1, 'Navigation', 'Sextant'),
    (104, 3, 'Clothes', 'Hat-polar Explorer'),
    (105, 5, 'Equipment', 'Pith Helmet'),
    (106, 2, 'Clothes', 'Pocket Knife-Nile'),
    (107, 3, 'Recreation', 'Pocket Knife-Nile'),
    (108, 1, 'Navigation', 'Compass'),
    (109, 2, 'Navigation', 'Geo positioning system'),
    (110, 5, 'Navigation', 'Map Measure'),
    (111, 1, 'Books', 'Geo positioning system'),
    (112, 1, 'Books', 'Sextant'),
    (113, 3, 'Books', 'Pocket Knife-Nile'),
    (114, 1, 'Navigation', 'Pocket Knife-Nile'),
    (115, 1, 'Equipment', 'Pocket Knife-Nile'),
    (116, 1, 'Clothes', 'Sextant'),
    (117, 1, 'Equipment', 'Sextant'),
    (118, 1, 'Recreation', 'Sextant'),
    (119, 1, 'Furniture', 'Sextant'),
    (120, 1, 'Furniture', 'Pocket Knife-Nile'),
    (121, 1, 'Books', 'Exploring in 10 Easy Lessons'),
    (122, 1, 'Books', 'How to win Foreign Friends'),
    (123, 1, 'Books', 'Compass'),
    (124, 1, 'Books', 'Pith Helmet'),
    (125, 1, 'Recreation', 'Elephant Polo stick'),
    (126, 1, 'Recreation', 'Camel Saddle');

SELECT * FROM Employee;
SELECT * FROM Department;
SELECT * FROM Sales;
SELECT * FROM Item;
