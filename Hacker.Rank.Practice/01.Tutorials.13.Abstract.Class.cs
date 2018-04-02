using System;

namespace Hacker.Rank.Practice
{

    class _01Tutorials13AbstractClass
    {

        public static void Answer()
        {
            AbstractClass();
        }

        static void AbstractClass()
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }

    }

    abstract class Book
    {
        protected String title;
        protected String author;
        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();
    }

    class MyBook : Book
    {
        int price;
        public MyBook(string Title, string Author, int Price)
            : base(Title, Author)
        {
            price = Price;
        }
        public override void display()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);
        }
    }

}
