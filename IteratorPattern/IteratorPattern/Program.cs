using IteratorPattern;

public class Program
{
    public static void Main()
    {
        Library library = new Library();

        library.AddBook(new Book("Война и мир", "Лев Толстой", 1869));
        library.AddBook(new Book("Евгений Онегин", "Александр Пушкин", 1831));
        library.AddBook(new Book("Приключения Алисы в Стране чудес", "Льюис Кэрролл", 1865));

        foreach (var book in library) Console.WriteLine(book);
    }
}