// Tests are in Program.cs
class Library
{
    string Name {get; set;}
    string Address {get; set;}
    List<Book> Books;
    List<MediaItem> MediaItems;

    public Library(string name, string address, List<Book> books, List<MediaItem> mediaItems)
    {
        this.Name = name;
        this.Address = address;
        this.Books = books;
        this.MediaItems = mediaItems;
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        Books.Remove(book);
    }

    public void AddMediaItem(MediaItem item)
    {
        MediaItems.Add(item);
    }

    public void RemoveMediaItem(MediaItem item)
    {
        MediaItems.Remove(item);
    }

    public void PrintCatalog()
    {
        Console.WriteLine();
        Console.WriteLine("The books in the library are: ");
        foreach (var book in Books)
        {
            Console.WriteLine($"{book.Title} by {book.Author}. ISBN: {book.ISBN}. Published: {book.PublicationYear}");
        }
        Console.WriteLine();
        Console.WriteLine("The catalogs in the library are: ");
        foreach (var item in MediaItems)
        {
            Console.WriteLine($"{item.Title}. Type: {item.MediaType}. Duration: {item.Duration}");
        }
    }
}

class Book
{
    public string Title {get;}
    
    public string Author {get;}
    public string ISBN {get;}
    public int PublicationYear {get;}

    public Book(string title, string author, string isbn, int publicationYear)
    {
        this.Title = title;
        this.Author = author;
        this.ISBN = isbn;
        this.PublicationYear = publicationYear;
    }
}

class MediaItem
{
    public string Title {get;}
    public string MediaType {get;}
    public int Duration {get;}

    public MediaItem(string title, string mediaType, int duration)
    {
        this.Title = title;
        this.MediaType = mediaType;
        this.Duration = duration;
    }
}