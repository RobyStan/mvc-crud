# Book Library Web Application

This is a simple ASP.NET Core web application that allows users to manage a collection of books and their authors. The app demonstrates core CRUD operations, data validation, and search functionality, using Entity Framework Core migrations for database management.

## Features

- Create and manage a relational database with `Book` and `Author` tables.
- Display a list of all books with their respective authors on the main page.
- Add new books via a form with proper validation.
- Edit existing books, with form fields pre-populated for ease of update.
- Delete books from the database.
- Search for books by author name.

## Technologies Used

- ASP.NET Core   
- C#
- Entity Framework Core 
- SQL Server 
- MVC

## Database Schema

- **Author**  
  - `Id` (Primary Key, auto-increment)  
  - `Name` (string)  
  - `DateOfBirth` (DateTime)

- **Book**  
  - `Id` (Primary Key, auto-increment)  
  - `Title` (string)  
  - `ISBN` (string)  
  - `Genre` (string)  
  - `AuthorId` (Foreign Key referencing `Author.Id`)
 
## Usage

- The homepage lists all books with their authors.
- Use the **Add Book** form to insert new books.
- Click **Edit** on a book to update its details.
- Use the **Delete** button to remove a book.
- Use the search bar to find books by author name.

## Validation

- All input fields are validated for required values and proper formats (e.g., ISBN format).
- Editing a book pre-populates the form with existing data for convenience.
