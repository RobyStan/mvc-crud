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

  ## Screenshots

### Homepage - List of Books with Authors
<img width="1919" height="424" alt="image" src="https://github.com/user-attachments/assets/bc65c275-9303-4019-9779-fb101e425778" />


### Add Book Form
<img width="1919" height="425" alt="image" src="https://github.com/user-attachments/assets/1727849a-a89d-4cea-b19d-5b2e45a168c9" />
<img width="1919" height="463" alt="image" src="https://github.com/user-attachments/assets/8dd2b1d3-3cf4-4ab7-81db-144d8b9e4650" />


### Edit Book Form
<img width="1919" height="474" alt="image" src="https://github.com/user-attachments/assets/169debc6-8c86-498c-86d0-ce898371ca39" />
<img width="1919" height="478" alt="image" src="https://github.com/user-attachments/assets/ed9412c8-8b3e-4e40-8d7f-304211af9306" />


### Delete Book Form
<img width="1919" height="396" alt="image" src="https://github.com/user-attachments/assets/638cf57f-7365-4ac3-919f-1ee08627d28d" />
<img width="1919" height="428" alt="image" src="https://github.com/user-attachments/assets/74f24931-5755-40a5-9ded-4b8c8c00c987" />

### Search Books by Author
<img width="1919" height="327" alt="image" src="https://github.com/user-attachments/assets/4c478de3-3b9b-45fe-968e-0e5ddd63a140" />



