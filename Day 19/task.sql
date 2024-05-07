-- 1) Create a stored procedure that will take the author firstname and print all the books polished by him with the publisher's name
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

-- EXEC proc_GetBooksByAuthor @FirstName = '';

-- 2) Create a sp that will take the employee's firtname and print all the titles sold by him/her, price, quantity and the cost.

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

-- EXEC proc_GetTitlesSoldByEmployeeALT @Name = 'Ar';


-- 3) Create a query that will print all names from authors and employees

SELECT au_fname AS 'First Name', au_lname AS 'Last Name' FROM authors
union
SELECT fname, lname  FROM employee;

-- 4) Create a  query that will float the data from sales,titles, publisher and authors table to print title name, Publisher's name, author's full name with quantity ordered and price for the order for all orders,

SELECT TOP 5 t.title AS Title, p.pub_name AS Publisher, CONCAT(a.au_fname, ' ', a.au_lname) AS AuthorFullName,
    s.qty AS QuantityOrdered, t.price AS Price
FROM sales s
INNER JOIN titles t ON s.title_id = t.title_id
INNER JOIN publishers p ON t.pub_id = p.pub_id
INNER JOIN titleauthor ta ON t.title_id = ta.title_id
INNER JOIN authors a ON ta.au_id = a.au_id