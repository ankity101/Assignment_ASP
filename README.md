# ASP.NET Core API README

This README provides an overview of the ASP.NET Core API project, including installation instructions, usage guidelines, and snapshots of the running API.

## Table of Contents
1. [Introduction](#introduction)
2. [Installation](#installation)
3. [Usage](#usage)
4. [API Documentation](#api-documentation)
5. [API ENDPOINTS](#api-endpoins)

## Introduction

[Assignment_ASP] is an ASP.NET Core API designed to handle tasks management. It follows RESTful principles and includes a service layer for business logic related to tasks.

## Installation

To run this API on your local machine, follow these steps:

1. Clone the repository:

git clone https://github.com/ankity101/Assignment_ASP


2. Install the necessary dependencies:


3. Configure the database connection in `appsettings.json` or provide the necessary environment variables.

4. Apply EF Core migrations to create the database schema:


5. Run the API:

## Screenshots

Go to ScreenShots Folder to have a look of documented API.

## API Documentation

API documentation is automatically generated using Swagger/OpenAPI. To access the documentation
kindly fork my repo.

## API endpoins
--For Friend Model:
- `GET /api/Friends`: Retrieve all Friend.
- `GET /api/Friends/{name}`: Retrieve a Friend by name.
- `POST /api/Friends`: Create a new Friend.
- `PUT /api/Friends/`: Update a Friend.
- `DELETE /api/Friends/{name}`: Delete a Friend by name.

--For Users Model:
- `GET /api/Users`: Retrieve all Users.
- `GET /api/Users/{id}`: Retrieve a Users by id.
- `POST /api/Users`: Create a new user.
- `PUT /api/Users/`: Update a user.
- `DELETE /api/Users/{id}`: Delete a User by id.

--For PostData Model:
- `GET /api/PostData`: Retrieve all PostData.
- `GET /api/PostData/{id}`: Retrieve a PostData by id.
- `POST /api/PostData`: Create a new PostData.
- `PUT /api/PostData/`: Update a PostData.
- `DELETE /api/PostData/{name}`: Delete a PostData by name.



