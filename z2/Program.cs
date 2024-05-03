using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Book
    {
        public Title title;
        public Author author;
        public Content content;
        public Book() { }
        public Book(string title, string author, string content)
        {
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);
        }
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            title.Show();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            author.Show();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Cyan;
            content.Show();
            Console.ResetColor();
        }
    }
    class Title
    {
        public string title;
        public Title() { }  
        public Title(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.Write(title);
        }
    }
    class Author
    {

        public string author;
        public Author() { }
        public Author(string author)
        {
            this.author = author;
        }

        public void Show() 
        {
            Console.Write(author);
        }

    }
    class Content
    {
        
        public string content;
        public Content()
        {
        }
        public Content(string content)
        {
            this.content = content;
        }

        public void Show() { Console.Write(content); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название книги: ");
            string title = Console.ReadLine();
            Console.Write("Введите ФИО автора: ");
            string author = Console.ReadLine();
            Console.Write("Введите жанр книги: ");
            string content = Console.ReadLine();
            Book book = new Book(title,author,content);
            book.Show();
            Console.ReadKey();
        }
    }
}
