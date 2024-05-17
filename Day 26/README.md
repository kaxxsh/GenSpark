# GenSpark Training Day 26 May

# Pizza Shop API

This project is a part of the Pizza Shop system, aimed at providing API endpoints for managing pizza orders, pizzas, and users.

## Introduction

The Pizza Shop API offers a range of functionalities to handle pizza-related data. It allows users to perform CRUD (Create, Read, Update, Delete) operations on pizza orders, pizzas, and user records.

## API Routes

### `/api/Order/`

#### GET `/api/Order/`

- **Description:** Retrieves a list of all pizza orders.
- **Parameters:** None
- **Returns:** A JSON array containing details of all pizza orders.

#### POST `/api/Order/`

- **Description:** Creates a new pizza order.
- **Parameters:** JSON object containing order details.
- **Returns:** The created order object with assigned ID.

#### GET `/api/Order/{id}`

- **Description:** Retrieves details of a specific pizza order.
- **Parameters:** `id` - The unique identifier of the order.
- **Returns:** JSON object containing details of the specified order.

#### PUT `/api/Order/{id}`

- **Description:** Updates details of a specific pizza order.
- **Parameters:**
  - `id` - The unique identifier of the order.
  - JSON object containing updated order details.
- **Returns:** Updated order object.

#### DELETE `/api/Order/{id}`

- **Description:** Deletes a specific pizza order.
- **Parameters:** `id` - The unique identifier of the order.
- **Returns:** Status code indicating success or failure of deletion.

### `/api/Pizza/`

#### GET `/api/Pizza/`

- **Description:** Retrieves a list of all available pizzas.
- **Parameters:** None
- **Returns:** A JSON array containing details of all pizzas.

#### POST `/api/Pizza/`

- **Description:** Creates a new pizza.
- **Parameters:** JSON object containing pizza details.
- **Returns:** The created pizza object with assigned ID.

#### GET `/api/Pizza/{id}`

- **Description:** Retrieves details of a specific pizza.
- **Parameters:** `id` - The unique identifier of the pizza.
- **Returns:** JSON object containing details of the specified pizza.

#### PUT `/api/Pizza/{id}`

- **Description:** Updates details of a specific pizza.
- **Parameters:**
  - `id` - The unique identifier of the pizza.
  - JSON object containing updated pizza details.
- **Returns:** Updated pizza object.

#### DELETE `/api/Pizza/{id}`

- **Description:** Deletes a specific pizza.
- **Parameters:** `id` - The unique identifier of the pizza.
- **Returns:** Status code indicating success or failure of deletion.

### `/api/User/`

#### GET `/api/User/`

- **Description:** Retrieves a list of all users.
- **Parameters:** None
- **Returns:** A JSON array containing details of all users.

#### POST `/api/User/`

- **Description:** Creates a new user.
- **Parameters:** JSON object containing user details.
- **Returns:** The created user object with assigned ID.

#### GET `/api/User/{id}`

- **Description:** Retrieves details of a specific user.
- **Parameters:** `id` - The unique identifier of the user.
- **Returns:** JSON object containing details of the specified user.

#### PUT `/api/User/{id}`

- **Description:** Updates details of a specific user.
- **Parameters:**
  - `id` - The unique identifier of the user.
  - JSON object containing updated user details.
- **Returns:** Updated user object.

#### DELETE `/api/User/{id}`

- **Description:** Deletes a specific user.
- **Parameters:** `id` - The unique identifier of the user.
- **Returns:** Status code indicating success or failure of deletion.

## Dependencies

- .NET Framework
- Entity Framework Core
- ASP.NET Web API
- Jwt Token

## Repository

The code and scripts related to the tasks can be found in this [repository](https://github.com/your-username/your-repository).
