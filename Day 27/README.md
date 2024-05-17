# GenSpark Training Day 27 May

# Employee Request Tracker API

This project is a part of the Employee Request Tracker system, aimed at providing API endpoints for managing employee requests, users, and authentication.

## Introduction

The Employee Request Tracker API offers a range of functionalities to handle employee request-related data. It allows users to perform CRUD (Create, Read, Update, Delete) operations on employee requests, manage users, and authenticate using JWT tokens.

## API Routes

### `/api/Request/`

#### GET `/api/Request/`

- **Description:** Retrieves a list of all employee requests.
- **Parameters:** None
- **Returns:** A JSON array containing details of all employee requests.

#### POST `/api/Request/`

- **Description:** Creates a new employee request.
- **Parameters:** JSON object containing request details.
- **Returns:** The created request object with assigned ID.

#### GET `/api/Request/{id}`

- **Description:** Retrieves details of a specific employee request.
- **Parameters:** `id` - The unique identifier of the request.
- **Returns:** JSON object containing details of the specified request.

#### PUT `/api/Request/{id}`

- **Description:** Updates details of a specific employee request.
- **Parameters:**
  - `id` - The unique identifier of the request.
  - JSON object containing updated request details.
- **Returns:** Updated request object.

#### DELETE `/api/Request/{id}`

- **Description:** Deletes a specific employee request.
- **Parameters:** `id` - The unique identifier of the request.
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

### `/api/Auth/`

#### POST `/api/Auth/Login`

- **Description:** Authenticates a user and generates a JWT token.
- **Parameters:** JSON object containing user credentials.
- **Returns:** JWT token.

## Dependencies

- .NET Framework
- Entity Framework Core
- ASP.NET Web API
- Jwt Token

## Repository

The code and scripts related to the tasks can be found in this [repository](https://github.com/your-username/your-repository).
