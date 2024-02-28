-Book.cs: 
Represents the model for a book with properties like Name, Author, Genre, and Page.

-BookDetailPresenter.cs: 
Manages the logic for the book detail view. It interacts with the IBookDetailView interface and handles 
operations like saving or canceling changes.

-BooksPresenter.cs: 
Manages the logic for the main books view. It interacts with the IBooksView interface and handles operations like 
adding, editing, searching, deleting, and viewing books.

-BookRepository.cs: 
Represents a simple in-memory repository for managing books. It provides methods for CRUD operations on books.

-IBookRepository.cs:
An interface defining the contract for the book repository.

-BookViewModel.cs: 
Represents the view model for a book, encapsulating the logic related to displaying and validating data. 
It also includes the ViewMode enum, indicating whether the view is in Insert, Update, or View mode.

-BookDetailForm.cs:
Represents the form for displaying book details. It interacts with the BookDetailPresenter and implements the IBookDetailView interface.

-BooksForm.cs: 
Represents the main form for displaying the list of books. It interacts with the BooksPresenter and implements the IBooksView interface.