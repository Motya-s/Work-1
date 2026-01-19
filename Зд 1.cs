using System;

class Book
{
    
    private string title;
    private int pages;

    
    public string Title

    {

        get { return title; }
        set { title = value; }

    }

    public int Pages

    {

        get { return pages; }
        set

        {

            if (value >= 1 && value <= 5000)

            {

                pages = value;

            }

            else

            {

                Console.WriteLine("Страниц должно быть от 1 до 5000!");

            }
        }
    }

    
    public Book(string title, int pages)

    {

        this.Title = title;  
        this.Pages = pages;

    }

    
    public Book(string title) : this(title, 100)

    {

    }

    
    public Book() : this("Без названия")

    {
         
        
    }

    public void Read()

    {

       
        if (pages > 0)

        {

            Console.WriteLine($"Читаю книгу \"{Title}\", страниц: {Pages}.");

        }

    }

}

class Program

{

    static void Main()

    {
        
        Book book1 = new Book("Война и мир", 1200);
        Book book2 = new Book("1984");
        Book book3 = new Book();

        book1.Read();
        book2.Read();
        book3.Read();

        Book badBook = new Book("Нет такой книги с таким кол-во страниц", 0);

        Console.ReadLine();

    }

}