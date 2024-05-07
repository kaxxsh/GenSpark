# GenSpark Training Day 19 May

This repository contains code examples and tasks completed during the GenSpark training session on May 19th. Below you'll find details about the tasks completed, along with the corresponding SQL queries and stored procedures.

## Tasks

### 1. Stored Procedure to Get Books by Author

```sql
CREATE PROCEDURE proc_GetBooksByAuthor(@FirstName VARCHAR(50))
AS
BEGIN
    SELECT t.title AS 'Book Title', p.pub_name AS 'Publisher'
    FROM titles t
    INNER JOIN titleauthor ta ON t.title_id = ta.title_id
    INNER JOIN authors a ON ta.au_id = a.au_id
    INNER JOIN publishers p ON t.pub_id = p.pub_id
    WHERE a.au_fname = @FirstName;
END
```

### 2. Stored Procedure to Get Titles Sold by Employee

```sql
CREATE PROCEDURE proc_GetTitlesSoldByEmployeeALT
    @Name VARCHAR(20)
AS
BEGIN
    SELECT t.title, s.qty, t.price, s.qty * t.price AS cost
    FROM sales s
    INNER JOIN titles t ON s.title_id = t.title_id
    INNER JOIN employee e ON t.pub_id = e.pub_id
    WHERE e.fname LIKE '%' + @Name + '%' OR e.lname LIKE '%' + @Name + '%';
END
```

### 3. Query to Get All Names from Authors and Employees

```sql
SELECT au_fname AS 'First Name', au_lname AS 'Last Name' FROM authors
UNION
SELECT fname, lname  FROM employee;
```

### 4. Query to Get Title Name, Publisher's Name, Author's Full Name, Quantity Ordered, and Price for All Orders

```sql
SELECT TOP 5 t.title AS Title, p.pub_name AS Publisher, CONCAT(a.au_fname, ' ', a.au_lname) AS AuthorFullName,
    s.qty AS QuantityOrdered, t.price AS Price
FROM sales s
INNER JOIN titles t ON s.title_id = t.title_id
INNER JOIN publishers p ON t.pub_id = p.pub_id
INNER JOIN titleauthor ta ON t.title_id = ta.title_id
INNER JOIN authors a ON ta.au_id = a.au_id
```

## Repository

The code and scripts related to the tasks can be found in this [repository](https://github.com/gayat19/FSD09Apr2024).
