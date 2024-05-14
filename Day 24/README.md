# GenSpark Training Day 24 May

# Doctor Management API

This project is a part of the Doctor Management system, aimed at providing API endpoints for managing doctors.

## Introduction

The Doctor Management API offers a range of functionalities to handle doctor-related data. It allows users to perform CRUD (Create, Read, Update, Delete) operations on doctor records.

## API Routes

### `/api/Doctor/`

#### GET `/api/Doctor/`

- **Description:** Retrieves a list of all doctors.
- **Parameters:** None
- **Returns:** A JSON array containing details of all doctors.

#### POST `/api/Doctor/`

- **Description:** Creates a new doctor record.
- **Parameters:** JSON object containing doctor details.
- **Returns:** The created doctor object with assigned ID.

#### GET `/api/Doctor/{id}`

- **Description:** Retrieves details of a specific doctor.
- **Parameters:** `id` - The unique identifier of the doctor.
- **Returns:** JSON object containing details of the specified doctor.

#### PUT `/api/Doctor/{id}`

- **Description:** Updates details of a specific doctor.
- **Parameters:**
  - `id` - The unique identifier of the doctor.
  - JSON object containing updated doctor details.
- **Returns:** Updated doctor object.

#### DELETE `/api/Doctor/{id}`

- **Description:** Deletes a specific doctor record.
- **Parameters:** `id` - The unique identifier of the doctor.
- **Returns:** Status code indicating success or failure of deletion.

## Dependencies

- .NET Framework
- Entity Framework Core
- ASP.NET Web API

## Repository

The code and scripts related to the tasks can be found in this [repository](https://github.com/gayat19/FSD09Apr2024).
