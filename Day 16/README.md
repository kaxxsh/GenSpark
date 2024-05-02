# GenSpark Training Day 16 May

# SQL TASK

## 1. Print all the titles names

To print all the book titles from the `books` table, you can use the following SQL query

![1](https://github.com/kaxxsh/GenSpark/blob/main/Results/Day%2016/1.png)

```
SELECT title FROM titles;

```

## 2. Print all the titles that have been published by 1389

To print all the book titles published by the publisher with ID 1389, you can use the following SQL query

![2](https://github.com/kaxxsh/GenSpark/blob/main/Results/Day%2016/2.png)

```
SELECT title FROM titles WHERE pub_id = '1389';

```

## 3. Print the books that have price in the range of 10 to 15

To print the titles of books with prices in the range of 10 to 15, you can use the following SQL query

![3](https://github.com/kaxxsh/GenSpark/blob/main/Results/Day%2016/3.png)

```
SELECT title titles WHERE price BETWEEN 10 AND 15;

```

## 4. Print those books that have no price

To print the titles of books that do not have a listed price, you can use the following SQL query

![4](https://github.com/kaxxsh/GenSpark/blob/main/Results/Day%2016/4.png)

```
SELECT title FROM titles WHERE price IS NULL;

```

## 5. Print the book names that start with 'The'

To print the titles of books whose names start with the word "The", you can use the following SQL query

![5](https://github.com/kaxxsh/GenSpark/blob/main/Results/Day%2016/5.png)

```
SELECT title FROM titles WHERE title LIKE 'The%';

```

## 6. Print the book names that do not have 'v' in their name

To print the titles of books that do not contain the letter 'v' in their names, you can use the following SQL query

![6](https://github.com/kaxxsh/GenSpark/blob/main/Results/Day%2016/6.png)

```
SELECT title FROM titles WHERE title NOT LIKE '%v%';

```

## 7. Print the books sorted by royalty

To print the titles of books sorted by their royalty, you can use the following SQL query

![7](https://github.com/kaxxsh/GenSpark/blob/main/Results/Day%2016/7.png)

```
SELECT title FROM titles ORDER BY royalty;

```

## 8. Print the books sorted by publisher in descending order, then by types in ascending order, then by price in descending order

To print the titles of books sorted by publisher ID in descending order, then by type in ascending order, and finally by price in descending order, you can use the following SQL query

![8](https://github.com/kaxxsh/GenSpark/blob/main/Results/Day%2016/8.png)

```
SELECT title FROM titles ORDER BY pub_id DESC, type ASC, price DESC;

```

## 9. Print the average price of books in every type

To calculate the average price of books for each type, you can use the following

![9](https://github.com/kaxxsh/GenSpark/blob/main/Results/Day%2016/9.png)

```
SELECT type, AVG(price) AS average_price FROM titles GROUP BY type;

```

## 10. Print all the types in unique

To retrieve all unique types of books available in the bookstore, you can use the following SQL query

![10](https://github.com/kaxxsh/GenSpark/blob/main/Results/Day%2016/10.png)

```
SELECT DISTINCT type FROM titles;

```

## 11. Print the first 2 costliest books

To retrieve the titles of the first 2 costliest books, you can use the following SQL query

![11](https://github.com/kaxxsh/GenSpark/blob/main/Results/Day%2016/11.png)

```
SELECT TOP 2 title FROM titles ORDER BY price DESC;

```

## 12. Print books that are of type business, have a price less than 20, and an advance greater than 7000

To retrieve the titles of books that are of type 'business', have a price less than 20, and an advance greater than 7000, you can use the following SQL query

![12](https://github.com/kaxxsh/GenSpark/blob/main/Results/Day%2016/12.png)

```
SELECT title FROM titles WHERE type = 'business' AND price < 20 AND advance > 7000;

```

## 13. Select publisher ID and the number of books which have price between 15 to 25 and have 'It' in its name, and print only those with a count greater than 2, sorted in ascending order of count

To select the publisher ID and the count of books with prices between 15 to 25 and 'It' in their names, and print only those with a count greater than 2, sorted in ascending order of count, you can use the following SQL query

![13](https://github.com/kaxxsh/GenSpark/blob/main/Results/Day%2016/13.png)

```
SELECT pub_id, COUNT(*) AS book_count FROM titles WHERE price BETWEEN 15 AND 25 AND title LIKE '%It%' GROUP BY pub_id HAVING COUNT(*) > 2 ORDER BY COUNT(*) ASC;

```

## 14. Print the authors who are from 'CA'

To retrieve the names of authors who are from the state of California ('CA'), you can use the following SQL query

![14](https://github.com/kaxxsh/GenSpark/blob/main/Results/Day%2016/14.png)

```
SELECT au_lname, au_fname FROM authors WHERE state = 'CA';

```

## 15. Print the count of authors from every state

To calculate the count of authors from each state, you can use the following SQL query

![15](https://github.com/kaxxsh/GenSpark/blob/main/Results/Day%2016/15.png)

```
SELECT state, COUNT(*) AS author_count FROM authors GROUP BY state;

```

## Repository

The repository for this project can be found [here](https://github.com/gayat19/FSD09Apr2024).