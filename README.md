![image](https://github.com/MohamedRadyA/LibraryManagementSystem/assets/42236845/b091c8c9-15c5-4480-9df0-8100bb60d187)# LibraryManagementSystem

# Library Management System (LMS) - C# WinForms

The Library Management System is a comprehensive software solution designed to simplify and automate the management of library operations. Developed using C# WinForms, this system provides a user-friendly interface for both librarians and library members. It includes features for user registration, book management, and book borrowing, ensuring a smooth and efficient library experience. By leveraging advanced SQL queries, including joins and subqueries, the system guarantees efficient data retrieval and manipulation, making it an ideal choice for libraries looking to modernize their operations.

## Features

- **User Registration**: Allows new users to register, creating a personalized experience and enabling librarians to track borrowing habits.
- **Book Management**: Enables librarians to add, update, and remove books from the library's catalog, ensuring that the library's inventory is always up-to-date.
- **Book Borrowing**: Simplifies the process of borrowing books, including tracking which user has borrowed a book and when it is due back.

## Getting Started

### Prerequisites

To run this Library Management System, ensure you have the following installed:
- .NET Framework 4.7.2 or later
- Microsoft SQL Server

### Installation

1. Clone the repository to your local machine:
    ```sh
    git clone https://github.com/MohamedRadyA/LibraryManagementSystem
    ```
2. Open the solution file (`LibraryManagementSystem.sln`) in Visual Studio.
3. Restore NuGet packages to resolve any dependencies.
4. Update the connection string in `App.config` to match your SQL Server instance.
5. Build and run the application from Visual Studio.

### Database Setup

1. Execute the SQL scripts located in the `Database` folder to create the necessary tables and relationships in your SQL Server instance.
2. Optionally, seed the database with initial data by running the seed script provided in the `Database\Seeds` directory.

## Usage

Upon launching the application, you will be greeted with the main interface, where you can navigate to different sections of the system:

- To register a new user, navigate to the `User Registration` section and fill out the form.
- To manage books, go to the `Book Management` section where you can add, update, or remove books.
- To borrow a book, access the `Book Borrowing` section, select a user and a book, and complete the borrowing process.

## Media

![image](https://github.com/MohamedRadyA/LibraryManagementSystem/assets/42236845/1246d67e-e109-4bf6-a06b-23106c84bd47)

![image](https://github.com/MohamedRadyA/LibraryManagementSystem/assets/42236845/958de519-9c64-46fc-917e-89e62d5f42b8)

![image](https://github.com/MohamedRadyA/LibraryManagementSystem/assets/42236845/2c91593e-bb0c-4e10-803b-b4905ff225b6)

![image](https://github.com/MohamedRadyA/LibraryManagementSystem/assets/42236845/dd45faba-0200-422f-a700-0c2390d22f47)

![image](https://github.com/MohamedRadyA/LibraryManagementSystem/assets/42236845/83a5261f-cf3e-407a-8bfc-0aa0130e3181)

![image](https://github.com/MohamedRadyA/LibraryManagementSystem/assets/42236845/3919e50b-61db-4356-bd58-2feee786758a)


## Diagrams

![image](https://github.com/MohamedRadyA/LibraryManagementSystem/assets/42236845/5c08807c-c429-4afa-94ca-51ce86a5241b)

![image](https://github.com/MohamedRadyA/LibraryManagementSystem/assets/42236845/125fa3e2-331d-4a19-941b-41f2268f8888)


## Built With

- **C# WinForms** - For the user interface
- **SQL Server** - For data storage and management
