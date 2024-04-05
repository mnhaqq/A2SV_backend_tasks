global using System;
using static Shape;

class MainClass
{
    static void Main()
    {
        // Shape Heirarchy
        Console.WriteLine("Shape Heirarchy");
        Circle circle = new Circle("New Circle", 3.5);
        Rectangle rectangle = new Rectangle("New Rectangle", 4, 3);
        Triangle triangle = new Triangle("New Triangle", 5.5, 3);

        PrintShapeArea(circle);
        PrintShapeArea(rectangle);
        PrintShapeArea(triangle);

        // Library Catalog
        Console.WriteLine(); 
        Console.WriteLine("Library Catalog");
        List<Book> books = new List<Book>();
        List<MediaItem> medias = new List<MediaItem>();

        Book book1 = new Book("Harry Potter", "JK Rowling", "1234", 2000);
        Book book2 = new Book("Animal Farm", "George Orwell", "8752", 200);
        Book book3 = new Book("No Way Home", "Mark Rust", "5234", 700);
        books.Add(book1);
        books.Add(book2);
        books.Add(book3);

        MediaItem mediaItem1 = new MediaItem("Movie", "CD", 100);
        MediaItem mediaItem2 = new MediaItem("Music", "DVD", 40);
        MediaItem mediaItem3 = new MediaItem("Football", "CD", 90);
        medias.Add(mediaItem1);
        medias.Add(mediaItem2);
        medias.Add(mediaItem3);

        Library library = new Library("My Library", "Legon", books, medias);
        library.PrintCatalog();
    }
}