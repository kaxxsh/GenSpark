# GenSpark Training Day 15 Apr 30

## Database Design for a Shop

Design a database for a shop that sells products. The database should consider the following points:

- One product can be supplied by many suppliers.
- One supplier can supply many products.
- All customer details have to be present.
- A customer can buy more than one product in every purchase.
- The bill for every purchase has to be stored.

Note: The shop details do not need to be stored.

![Shoping](https://github.com/kaxxsh/GenSpark/blob/main/Results/Day%2015/shoping.png)

## ER Modelling for a Movie Store

Create an ER model for a movie store with the following specifications:

...

- Each movie in the store has a title and is identified by a unique movie number.
- A movie can be in VHS, VCD, or DVD format.
- Each movie belongs to one of a given set of categories (action, adventure, comedy, etc.).
- The store has a name and a unique phone number for each member.
- Each member may provide a favorite movie category (used for marketing purposes).
- There are two types of members: Golden Members and Bronze Members.
- Golden Members can rent one or more movies using their credit cards, while Bronze Members can rent a maximum of one movie.
- A member may have a number of dependents (with known names), each of whom is allowed to rent one movie at a time.

![Movie](https://github.com/kaxxsh/GenSpark/blob/main/Results/Day%2015/movie.png)

## Table Schema

Create Tables with Integrity Constraints:

- EMP (empno - primary key, empname, salary, deptname - references entries in a deptname of department table with null constraint, bossno - references entries in an empno of emp table with null constraint)

- DEPARTMENT (deptname - primary key, floor, phone, empno - references entries in an empno of emp table not null)

- SALES (salesno - primary key, saleqty, itemname - references entries in an itemname of item table with not null constraint, deptname - references entries in a deptname of department table with not null constraint)

- ITEM (itemname - primary key, itemtype, itemcolor)


## Repository

The repository for this project can be found [here](https://github.com/gayat19/FSD09Apr2024).