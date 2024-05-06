# GenSpark Training Day 17 May

# SQL TASK

## 1. Print the store ID and the number of orders for the store

To print the store ID and the number of orders for each store, you can use the following SQL query

```
SELECT store_id, COUNT(order_id) AS NumberOfOrders FROM orders GROUP BY store_id;
```

## 2. Print the number of orders for every title

To print the number of orders for every title, you can use the following SQL query

```
SELECT title, COUNT(order_id) AS NumberOfOrders FROM orders JOIN titles ON orders.title_id = titles.title_id GROUP BY title;
```

## 3. Print the publisher name and book name

To print the publisher name and book name for each book, you can use the following SQL query

```
SELECT publishers.name AS PublisherName, titles.title AS BookName FROM titles JOIN publishers ON titles.pub_id = publishers.pub_id;
```

## 4. Print the author full name for all the authors

To print the full name of each author, you can use the following SQL query

```
SELECT au_fname || ' ' || au_lname AS FullName FROM authors;
```

## 5. Print the price of every book with tax (price + price*12.36/100)

To print the price of every book with tax included, you can use the following SQL query

```
SELECT title, price, price + price * 12.36 / 100 AS PriceWithTax FROM titles;
```

## 6. Print the author name, title name

To print the author name and title name for each book, you can use the following SQL query

```
SELECT authors.au_fname || ' ' || authors.au_lname AS AuthorName, titles.title FROM titles JOIN titleauthor ON titles.title_id = titleauthor.title_id JOIN authors ON titleauthor.au_id = authors.au_id;
```

## 7. Print the author name, title name, and the publisher name

To print the author name, title name, and publisher name for each book, you can use the following SQL query

```
SELECT authors.au_fname || ' ' || authors.au_lname AS AuthorName, titles.title, publishers.name AS PublisherName FROM titles JOIN titleauthor ON titles.title_id = titleauthor.title_id JOIN authors ON titleauthor.au_id = authors.au_id JOIN publishers ON titles.pub_id = publishers.pub_id;
```

## 8. Print the average price of books published by every publisher

To calculate the average price of books for each publisher, you can use the following SQL query

```
SELECT publishers.name, AVG(titles.price) AS AveragePrice FROM titles JOIN publishers ON titles.pub_id = publishers.pub_id GROUP BY publishers.name;
```

## 9. Print the books published by 'Marjorie'

To print the books published by 'Marjorie', you can use the following SQL query

```
SELECT title FROM titles JOIN publishers ON titles.pub_id = publishers.pub_id WHERE publishers.name = 'Marjorie';
```

## 10. Print the order numbers of books published by 'New Moon Books'

To print the order numbers of books published by 'New Moon Books', you can use the following SQL query

```
SELECT orders.order_id FROM orders JOIN titles ON orders.title_id = titles.title_id JOIN publishers ON titles.pub_id = publishers.pub_id WHERE publishers.name = 'New Moon Books';
```

## 11. Print the number of orders for every publisher

To print the number of orders for every publisher, you can use the following SQL query

```
SELECT publishers.name, COUNT(orders.order_id) AS NumberOfOrders FROM orders JOIN titles ON orders.title_id = titles.title_id JOIN publishers ON titles.pub_id = publishers.pub_id GROUP BY publishers.name;
```

## 12. Print the order number, book name, quantity, price, and the total price for all orders

To print the order number, book name, quantity, price, and the total price for all orders, you can use the following SQL query

```
SELECT orders.order_id, titles.title, orders.quantity, titles.price, orders.quantity * titles.price AS TotalPrice FROM orders JOIN titles ON orders.title_id = titles.title_id;
```

## 13. Print the total order quantity for every book

To print the total order quantity for every book, you can use the following SQL query

```
SELECT titles.title, SUM(orders.quantity) AS TotalQuantity FROM orders JOIN titles ON orders.title_id = titles.title_id GROUP BY titles.title;
```

## 14. Print the total order value for every book

To print the total order value for every book, you can use the following SQL query

```
SELECT titles.title, SUM(orders.quantity * titles.price) AS TotalOrderValue FROM orders JOIN titles ON orders.title_id = titles.title_id GROUP BY titles.title;
```

## 15. Print the orders that are for the books published by the publisher for which 'Paolo' works for

To print the orders for the books published by the publisher for which 'Paolo' works, you can use the following SQL query

```
SELECT orders.order_id FROM orders JOIN titles ON orders.title_id = titles.title_id JOIN publishers ON titles.pub_id = publishers.pub_id JOIN authors ON publishers.pub_id = authors.pub_id WHERE authors.au_fname = 'Paolo';
```

## Repository

The repository for this project can be found [here](https://github.com/gayat19/FSD09Apr2024).