# Dockerized PostgreSQL Database with Initial Data

This repository contains the necessary files to set up a PostgreSQL database using Docker, with initial tables and data preloaded via an SQL script.

## Prerequisites

- Docker installed on your machine.

## Setup Instructions

1. **Clone the Repository**:

   ```bash
   git clone <repository-url>
   cd <repository-directory>
   ```

2. **Build the Docker Image**:

   ```bash
   docker build -t postgres-db .
   ```

3. **Run the Docker Container**:

   ```bash
   docker run --name postgres-db-container -d postgres-db
   ```

4. **Verify the Setup**:
   - The PostgreSQL server will be running on.
   - You can connect to the database using a PostgreSQL client with the following credentials:
     - **Database**: dbDocker
     - **User**: postgres
     - **Password**: mysecretpassword

## Database Schema and Initial Data

The initial setup script `setup.sql` creates three tables and inserts some initial data into them:

### Tables

1. **Department**:

   - `department_id` (SERIAL PRIMARY KEY)
   - `department_name` (VARCHAR(50) NOT NULL)

2. **Employee**:

   - `employee_id` (SERIAL PRIMARY KEY)
   - `employee_name` (VARCHAR(50) NOT NULL)
   - `age` (INT)
   - `phone` (VARCHAR(15))
   - `department_id` (INT, FOREIGN KEY REFERENCES `Department(department_id)`)

3. **Salary**:
   - `salary_id` (SERIAL PRIMARY KEY)
   - `employee_id` (INT, FOREIGN KEY REFERENCES `Employee(employee_id)`)
   - `salary` (DECIMAL(10, 2))

### Initial Data

- **Department**:

  - HR
  - Finance
  - IT

- **Employee**:

  - kamesh, 30, 1234567890, HR
  - mukesh, 25, 2345678901, Finance
  - jv, 35, 3456789012, IT

- **Salary**:
  - kamesh: 50000.00
  - mukesh: 60000.00
  - jv: 70000.00

## Accessing the Database

## Executing the SELECT Query

To execute the SELECT query after the container is running, follow these steps:

1. Access the PostgreSQL container:

   ```bash
   docker exec -it postgres-db-container psql -U postgres -d dbDocker
   ```

2. Execute the SELECT query:

   ```bash
   SELECT
    e.employee_name,
    e.age,
    e.phone,
    d.department_name,
    s.salary
   FROM
    Employee e
   JOIN
    Department d ON e.department_id = d.department_id
   JOIN
    Salary s ON e.employee_id = s.employee_id;

   ```

   This will print the employee_name, age, phone, department_name, and salary for each employee as requested.
